using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Entity.ViewModels
{
    public class SatisRaporViewModel
    {
        public int SatisID { get; set; }
        public string KategoriAdi { get; set; }
        public string UrunAdi { get; set; }
        public short Adet { get; set; }
        public decimal Fiyat { get; set; }
        public decimal Toplam { get; set; }
        public DateTime SatisTarihi { get; set; }
    }
}
