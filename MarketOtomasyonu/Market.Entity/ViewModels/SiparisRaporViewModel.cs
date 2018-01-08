using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Entity.ViewModels
{
    public class SiparisRaporViewModel
    {
        public int SiparisID { get; set; }
        public string KategoriAdi { get; set; }
        public string UrunAdi { get; set; }
        public short Adet { get; set; }
        public decimal Fiyat { get; set; }
        public decimal Toplam { get; set; }
        public DateTime TeslimAlınmaGunu { get; set; }

    }
}
