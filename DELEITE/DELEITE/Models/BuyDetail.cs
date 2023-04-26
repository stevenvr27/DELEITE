using System;
using System.Collections.Generic;
using System.Text;

namespace DELEITE.Models
{
   public  class BuyDetail
    {
        public int BuyBuyId { get; set; }
        public int ItemIditem { get; set; }
        public decimal Amount { get; set; }
        public decimal UnitaryPrice { get; set; }
        public decimal Total { get; set; }

        public virtual Buy BuyBuy { get; set; } = null!;
        public virtual Items ItemIditemNavigation { get; set; } = null!;


    }
}
