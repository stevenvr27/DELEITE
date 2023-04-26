using System;
using System.Collections.Generic;
using System.Text;

namespace DELEITE.Models
{
    public class Items
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public string Image { get; set; }
        public bool HasOffer { get; set; }
        public int OfferPrice { get; set; }
    }
}
