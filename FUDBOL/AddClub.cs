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
    public partial class AddClub : Form
    {
        public AddClub()
        {
            InitializeComponent();
        }

        private void AddClub_Load(object sender, EventArgs e)
        {

        }
        public Fudbol BindModel()
        {
            Fudbol fudbol = new Fudbol();
            fudbol.Nomi = tbName.Text;
            fudbol.GalabalarSoni = int.Parse(tbGalaba.Text);
            fudbol.DuranglarSoni = int.Parse(tbDurang.Text);
            fudbol.MaglubiyatlarSoni = int.Parse(tbMaglubiyat.Text);
            fudbol.KiritilganToplarSoni = int.Parse(tbKiritilganTop.Text);
            fudbol.OtkazilganToplarSoni = int.Parse(tbOtkazilganTop.Text);
            return fudbol;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           
        }
    }
}
