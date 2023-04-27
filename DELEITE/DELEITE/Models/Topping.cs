using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DELEITE.Models
{
    public class Topping
    {
        public RestRequest Request { get; set; }
        public int ToppingId { get; set; }
        public string ToppingName { get; set; }  
        public decimal UnitPriceTopping { get; set; }
        public int Stock { get; set; }
        public int Iditem { get; set; }
         

        public virtual Item? IditemNavigation { get; set; } = null!;


        public async Task<List<Topping>> ListTopping()
        {
            try
            {
                string RouteSufix = string.Format("Toppings");

                string URL = Services.APIConnection.ProductionURLPrefix + RouteSufix;

                RestClient client = new RestClient(URL);

                Request = new RestRequest(URL, Method.Get);

                Request.AddHeader(Services.APIConnection.ApiKeyName, Services.APIConnection.ApiKeyValue);
                Request.AddHeader(GlobalObjects.ContentType, GlobalObjects.MimeType);


                RestResponse response = await client.ExecuteAsync(Request);

                HttpStatusCode statusCode = response.StatusCode;

                if (statusCode == HttpStatusCode.OK)
                {
                    var list = JsonConvert.DeserializeObject<List<Topping>>(response.Content);

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