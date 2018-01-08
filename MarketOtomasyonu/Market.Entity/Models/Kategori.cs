using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Entity.Models
{
    [Table("Kategoriler")]
    public class Kategori:Base
    {
        [StringLength(30)]
        [Required]
        public string KategoriAdi { get; set; }
        public string Aciklama { get; set; }
        public decimal Kdv { get; set; }
        public virtual List<Urun> Urunler { get; set; } = new List<Urun>();
        public override string ToString()
        {
            return $"{KategoriAdi}";
        }
    }
}
