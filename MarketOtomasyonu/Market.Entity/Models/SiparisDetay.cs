using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Entity.Models
{
    [Table("SiparisDetaylar")]

    public class SiparisDetay
    {
        [Key]
        [Column(Order = 1)]
        public int SiparisID { get; set; }
        [ForeignKey("SiparisID")]
        public virtual Siparis Siparis { get; set; }

        [Key]
        [Column(Order = 2)]
        public int TedarikciID { get; set; }
        [ForeignKey("TedarikciID")]
        public virtual Tedarikci Tedarikci { get; set; }

        [Key]
        [Column(Order = 3)]
        public int UrunID { get; set; }
        [ForeignKey("UrunID")]
        public virtual Urun Urun { get; set; }

        public decimal? UrunFiyati { get; set; } = 0;

        public int? Adet { get; set; } = 0;

    }
}
