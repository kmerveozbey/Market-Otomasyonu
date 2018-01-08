using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Entity.Models
{
    [Table("Urunler")]
    public class Urun : Base
    {
        public int KategoriID { get; set; }

        [StringLength(40)]
        [Index(IsUnique = true)]
        [Required]
        public string UrunBarkod { get; set; }

        [StringLength(40)]
        [Required]
        public string UrunAdi { get; set; }

        [StringLength(40)]
        [Required]
        public string Marka { get; set; }

        public short? Stok { get; set; }

        public decimal AlisFiyati { get { return SatisFiyati / (1 + Kategori.Kdv); } }

        public decimal SatisFiyati { get; set; } = 0;

        public decimal IndirimMiktari { get; set; } = 0;

        public byte[] Fotograf { get; set; }

        public bool? SatistaMi { get; set; }

        public virtual List<SatisDetay> SatisDetaylar { get; set; } = new List<SatisDetay>();
        public virtual List<SiparisDetay> SiparisDetaylar { get; set; } = new List<SiparisDetay>();

        [ForeignKey("KategoriID")]
        public virtual Kategori Kategori { get; set; }

        public override string ToString()
        {
            return $"{UrunBarkod} - {UrunAdi} - {SatisFiyati}";
        }
     
    }
}
