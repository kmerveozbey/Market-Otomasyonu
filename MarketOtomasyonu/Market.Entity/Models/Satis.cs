using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Entity.Models
{
    [Table("Satislar")]

    public class Satis:Base
    {
        public int CalisanID { get; set; }

        public decimal? ToplamFiyat { get; set; } = 0;

        public virtual List<SatisDetay> SatisDetaylar { get; set; } = new List<SatisDetay>();

        [ForeignKey("CalisanID")]
        public virtual Calisan Calisan { get; set; }
    }
}
