using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Entity
{
    public class SiparisViewModel
    {
        public string Barkod { get; set; }

        public string UrunAdi { get; set; }

        public string UrunID { get; set; }

        public string TedarikciAdi { get; set; }

        public int TedarikciID { get; set; }

        public decimal Fiyat { get; set; }

        public int Adet { get; set; }

        public decimal ToplamFiyat { get { return Adet * Fiyat; } }
    }
}
