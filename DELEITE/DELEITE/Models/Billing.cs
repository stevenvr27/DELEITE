using System;
using System.Collections.Generic;
using System.Text;

namespace DELEITE.Models
{
    public class Billing
    {

        public int BillingId { get; set; }
        public DateTime BillingDate { get; set; }
        public int Discount { get; set; }
        public string Description { get; set; } = null!;
        public string Paymethod { get; set; } = null!;
        public int UserId { get; set; }
        public int UserIds { get; set; }

        public virtual User User { get; set; } = null!;
        public virtual ICollection<BillingDetail> BillingDetails { get; set; }



    }
}
