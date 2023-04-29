using System;
using System.Collections.Generic;
using System.Text;

namespace DELEITE.Models
{
   public  class Deal
    {
        public int DealsId { get; set; }
        public decimal Descount { get; set; }
        public string? Description { get; set; } = null!;
        public bool Status { get; set; }

        public virtual Buy? Buy { get; set; } = null!;


    }
}
