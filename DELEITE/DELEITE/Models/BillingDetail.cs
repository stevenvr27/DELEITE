using DELEITE.ViewModels;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace DELEITE.Models
{
    public class BillingDetail
    {
        public int BillingBillingId { get; set; }
        public int ItemIditem { get; set; }
        public decimal Pirice { get; set; }
        public int CounterId { get; set; }

        public int Mount { get; set; }

        public virtual Billing? BillingBilling { get; set; } = null!;
        public virtual Counter? Counter { get; set; } = null!;
        public virtual Item? ItemIditemNavigation { get; set; } = null!;

    }
}
