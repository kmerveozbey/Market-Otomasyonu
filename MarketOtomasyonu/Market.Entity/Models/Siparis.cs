using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Entity.Models
{
    [Table("Siparisler")]

    public class Siparis:Base
    {
        public decimal? ToplamFiyat { get; set; } = 0;

        public DateTime TeslimTarihi { get; set; }

        public decimal IndirimMiktari { get; set; }

        public virtual List<SiparisDetay> SiparisDetaylar { get; set; } = new List<SiparisDetay>();
    }
}
