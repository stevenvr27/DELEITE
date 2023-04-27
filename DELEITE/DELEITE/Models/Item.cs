using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DELEITE.Models
{
    public class Item
    {
        RestRequest Request;

        public int Iditem { get; set; }
        public string NameItem { get; set; } 
        public string Qr { get; set; }  
        public decimal UnitCost { get; set; }
        public decimal SellPrice { get; set; }


        public virtual ICollection<BillingDetail>? BillingDetails { get; set; } = null;
        public virtual ICollection<BuyDetail>? BuyDetails { get; set; } = null;
        public virtual ICollection<Topping>? Toppings { get; set; } = null;
        public async Task<List<Item>> Listitems()
        {
            try
            {
                string RouteSufix = string.Format("Items");

                string URL = Services.APIConnection.ProductionURLPrefix + RouteSufix;

                RestClient client = new RestClient(URL);

                Request = new RestRequest(URL, Method.Get);

                Request.AddHeader(Services.APIConnection.ApiKeyName, Services.APIConnection.ApiKeyValue);
                Request.AddHeader(GlobalObjects.ContentType, GlobalObjects.MimeType);


                RestResponse response = await client.ExecuteAsync(Request);

                HttpStatusCode statusCode = response.StatusCode;

                if (statusCode == HttpStatusCode.OK)
                {
                    var list = JsonConvert.DeserializeObject<List<Item>>(response.Content);

                    return list;
                }
                else
                {
                    return null;
                }

            }
            catch (Exception ex)
            {
                string ErrorMsg = ex.Message;



                throw;
            }

        }
    }
}
