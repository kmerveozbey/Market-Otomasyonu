using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Entity.Models
{
    public abstract class Base
    {
        [Key]
        public int ID { get; set; }
        public DateTime OlusturmaTarihi { get; set; } = DateTime.Now;
    }
}
