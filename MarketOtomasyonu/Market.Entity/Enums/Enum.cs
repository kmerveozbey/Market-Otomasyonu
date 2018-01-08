using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Entity.Enums
{
    public class Enum
    {
        public enum OdemeTipi : byte { Nakit=0, KrediKartı=1 };
        public enum KartCesitleri : byte { Visa, MasterCard, Bonus, World };
    }
}
