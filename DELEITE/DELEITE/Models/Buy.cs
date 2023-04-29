using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DELEITE.Models
{
    public class Buy
    {
        public RestRequest Request { get; set; }
        const string MineType = "application/json";
        const string ContentType = "application/json";

        public Buy()
        {
            BuyDetails = new HashSet<BuyDetail>();
            Deals = new HashSet<Deal>();
        }

        public int BuyId { get; set; }
        public DateTime BuyDate { get; set; }
        public int BuyNumber { get; set; }
        public byte[]? BuyNotes { get; set; } = null;
        public bool Active { get; set; }
        public int UserId { get; set; }

        public virtual User? User { get; set; } = null!;
        public virtual ICollection<BuyDetail>? BuyDetails { get; set; } = null;
        public virtual ICollection<Deal>? Deals { get; set; } = null;

        public async Task<ObservableCollection<Buy>> GetBuyByUser()
        {
            try
            {  
                string RouteSufix = string.Format("Buys/GetbuyListByUser?pUserID={0}",
                                                this.UserId);

                string URL = Services.APIConnection.ProductionURLPrefix + RouteSufix;

                RestClient client = new RestClient(URL);








        }
    }
