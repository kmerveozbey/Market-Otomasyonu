using Market.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Entity
{
    public class SatisViewModel
    {
        public string Barkod { get; set; }

        public string UrunAdi { get; set; }

        public string UrunID { get; set; }

        public decimal Fiyat { get; set; }

        public int Adet { get; set; }

        public decimal KDV { get; set; }

        public decimal KDVSizFiyat { get; set; }

        public decimal ToplamFiyat { get {return Adet* Fiyat; }}
        
    }
}
