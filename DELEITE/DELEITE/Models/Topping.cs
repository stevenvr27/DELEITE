using System;
using System.Collections.Generic;
using System.Text;

namespace DELEITE.Models
{
    public class Topping
    {
        public int ToppingId { get; set; }
        public string? ToppingName { get; set; } = null!;
        public decimal UnitPriceTopping { get; set; }
        public int Stock { get; set; }
        public int Iditem { get; set; }

        public virtual Item? IditemNavigation { get; set; } = null!;
    }
}
