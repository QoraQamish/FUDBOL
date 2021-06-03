using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUDBOL.Entity
{
    public class Fudbol
    {
        public string Nomi { get; set; }
        public int GalabalarSoni { get; set; }
        public int DuranglarSoni { get; set; }
        public int MaglubiyatlarSoni { get; set; }
        public int KiritilganToplarSoni { get; set; }
        public int OtkazilganToplarSoni { get; set; }
        public string M { get => KiritilganToplarSoni.ToString() +"-"+ OtkazilganToplarSoni.ToString(); }
        
        public int PM { get => KiritilganToplarSoni - OtkazilganToplarSoni; }
        public int Ochki { get => GalabalarSoni * 3 + DuranglarSoni; }
    }
}
