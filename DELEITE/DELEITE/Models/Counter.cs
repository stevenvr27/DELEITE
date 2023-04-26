using System;
using System.Collections.Generic;
using System.Text;

namespace DELEITE.Models
{
    public class Counter
    {
        public int CounterId { get; set; }
        public decimal WeakCounter { get; set; }
        public decimal MounthCounter { get; set; }
        public decimal YearCounter { get; set; }

        public virtual ICollection<BillingDetail> BillingDetails { get; set; }

    }
}
