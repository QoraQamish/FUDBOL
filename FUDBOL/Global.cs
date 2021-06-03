using FUDBOL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUDBOL
{
    public static class Global
    {
        public static List<Fudbol> Fudbol = new List<Fudbol>();

        public static Fudbol[] fudbolsOrderBy()
        {
            Fudbol[] fudbol = new Fudbol[Fudbol.Count];
            int t = 0;
            foreach (var item in Fudbol)
            {
                fudbol[t] = item;
                t = t + 1;
            }
            Fudbol temp = new Fudbol();

            for (int write = 0; write < fudbol.Length; write++)
            {
                for (int sort = 0; sort < fudbol.Length - 1; sort++)
                {
                    if (fudbol[sort].Ochki < fudbol[sort + 1].Ochki)
                    {
                        temp = fudbol[sort + 1];
                        fudbol[sort + 1] = fudbol[sort];
                        fudbol[sort] = temp;
                    }
                    else if (fudbol[sort].Ochki == fudbol[sort + 1].Ochki &&
                         fudbol[sort].KiritilganToplarSoni - fudbol[sort].OtkazilganToplarSoni 
                         < fudbol[sort + 1].KiritilganToplarSoni - fudbol[sort + 1].OtkazilganToplarSoni)
                    {
                        temp = fudbol[sort + 1];
                        fudbol[sort + 1] = fudbol[sort];
                        fudbol[sort] = temp;
                    }
                }
            }

            return fudbol;
        }

    }
}
