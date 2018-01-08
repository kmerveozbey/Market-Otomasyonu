using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Entity
{
    public class FisViewModel
    {
        public string UrunAdi { get; set; }

        public int Adet { get; set; }

        public decimal Fiyat { get; set; }

        public decimal KDV { get; set; }

        public decimal ToplamFiyat { get { return Adet * Fiyat; } }
    }
}
