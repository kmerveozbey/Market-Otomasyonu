using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Entity.Models
{
    [Table("Tedarikciler")]

    public class Tedarikci : Base
    {
        [StringLength(40)]
        [Required]
        public string TedarikciAdi { get; set; }

        [StringLength(40)]
        [Required]
        public string SirketAdi { get; set; }

        [StringLength(40)]
        [Required]
        public string Adresi { get; set; }
        [StringLength(15)]
        [Required]
        public string Il { get; set; }
        [StringLength(15)]
        [Required]
        public string Ilce { get; set; }

        [StringLength(25)]
        [Required]
        public string TelefonNo { get; set; }

        [StringLength(45)]
        public string Email { get; set; }

        public virtual List<SiparisDetay> SiparisDetaylar { get; set; } = new List<SiparisDetay>();

        public override string ToString()
        {
            return $"{TedarikciAdi} - {TelefonNo} - {Email}";
        }
    }
}
