using System;
using System.Collections.Generic;
using System.Text;

namespace DELEITE.Models
{
    public class Methodpage
    {
        public int MethodpageId { get; set; }
        public string? Description { get; set; }
        public int? BillingId { get; set; }

        public virtual Billing? Billing { get; set; } = null;

    }
}
