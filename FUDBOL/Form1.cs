using FUDBOL.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FUDBOL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Refresh()
        {
            var source = new BindingSource(Global.fudbolsOrderBy(), null);
            dataGridView1.DataSource =source ;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            AddClub addClub = new AddClub();
            addClub.ShowDialog();
            if (DialogResult.OK==addClub.DialogResult)
            {
                if (addClub.BindModel() != null)
                {
                    Global.Fudbol.Add(addClub.BindModel());
                    Refresh();
                }
                
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
