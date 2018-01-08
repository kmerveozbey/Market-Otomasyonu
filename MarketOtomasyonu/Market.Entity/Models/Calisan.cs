using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Entity.Models
{
    [Table("Calisanlar")]

    public class Calisan:Base
    {
        [StringLength(40)]
        [Required]
        public string CalisanAdi { get; set; }

        [StringLength(40)]
        [Required]
        public string CalisanSoyadi { get; set; }

        [StringLength(25)]
        [Required]
        public string TelefonNumarasi { get; set; }

        [StringLength(45)]
        public string Eposta { get; set; }

        public virtual List<Satis> Satislar { get; set; } = new List<Satis>();

        public override string ToString()
        {
            return $"{CalisanAdi} {CalisanSoyadi}";
        }
    }
}
