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
        RestRequest request;

        public int Iditem { get; set; }
        public string NameItem { get; set; } = null!;
        public string? Qr { get; set; } = null!;
        public decimal UnitCost { get; set; }
        public decimal SellPrice { get; set; }
        public string? Flavor { get; set; } = null!;

        public virtual ICollection<BillingDetail>? BillingDetails { get; set; } = null;
        public virtual ICollection<BuyDetail>? BuyDetails { get; set; } = null;
        public virtual ICollection<Topping>? Toppings { get; set; } = null;
        public async Task<List<Item>> Getitems()
        {
            try
            {
                string RouteSufix = string.Format("Items");

                //con esto obtenemos la ruta completa de consumo del API 
                string URL = Services.APIConnection.ProductionURLPrefix + RouteSufix;

                RestClient client = new RestClient(URL);

                request = new RestRequest(URL, Method.Get);

                //agregamos la info de la llave de seguridad (ApiKey) 
                request.AddHeader(Services.APIConnection.ApiKeyName, Services.APIConnection.ApiKeyValue);
                request.AddHeader(GlobalObjects.ContentType, GlobalObjects.MimeType);

                //ejecución de la llamada al controlador 
                RestResponse response = await client.ExecuteAsync(request);

                HttpStatusCode statusCode = response.StatusCode;

                if (statusCode == HttpStatusCode.OK)
                {
                    //usamos newtonsoft para descomponer el paquete json que nos llega
                    //desde el API
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

                //almacenar registro de errores en una bitacora para analisis posterior 
                //también puede ser enviarlos a un servidor de captura de errores

                throw;
            }

        }

    }
}
