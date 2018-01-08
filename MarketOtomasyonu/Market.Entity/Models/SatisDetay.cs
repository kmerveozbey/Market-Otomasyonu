using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Market.Entity.Enums.Enum;

namespace Market.Entity.Models
{
    [Table("SatisDetaylar")]
    public class SatisDetay
    {
        [Key]
        [Column(Order = 1)]
        public int SatisID { get; set; }

        [Key]
        [Column(Order = 2)]
        public int UrunID { get; set; }

        public int? Adet { get; set; } = 0;

        public decimal? SatisFiyati { get; set; } = 0;

        [ForeignKey("SatisID")]
        public virtual Satis Satis { get; set; }

        [ForeignKey("UrunID")]
        public virtual Urun Urun { get; set; }

        public OdemeTipi? OdemeTipi { get; set; }

        public KartCesitleri KartCesitleri { get; set; }
    }
}
