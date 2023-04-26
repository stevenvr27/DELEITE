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

        public async Task<ObservableCollection<Buy>> GetbuyListByUser()
        {
            try
            {
                string RouteSufix = string.Format("Buys/GetbuyListByUser?pUserID={0}",
                                                  this.UserId);

                //con esto obtenemos la ruta completa de consumo del API 
                string URL = Services.APIConnection.ProductionURLPrefix + RouteSufix;

                RestClient client = new RestClient(URL);

                Request = new RestRequest(URL, Method.Get);

                //agregamos la info de la llave de seguridad (ApiKey) 
                Request.AddHeader(Services.APIConnection.ApiKeyName, Services.APIConnection.ApiKeyValue);
                Request.AddHeader(GlobalObjects.ContentType, GlobalObjects.MimeType);

                //ejecución de la llamada al controlador 
                RestResponse response = await client.ExecuteAsync(Request);

                HttpStatusCode statusCode = response.StatusCode;

                if (statusCode == HttpStatusCode.OK)
                {
                    //las colecciones observables sirven para la mayoría de controles (vistas) que administran listas
                    //como listview, collectionview, carrousel, etc

                    var buylist = JsonConvert.DeserializeObject<ObservableCollection<Buy>>(response.Content);

                    return buylist;
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



        public async Task<bool> Addbuynew()
        {
            try
            {
                string RouteSufix = string.Format("Buys");

                //con esto obtenemos la ruta completa de consumo del API 
                string URL = Services.APIConnection.ProductionURLPrefix + RouteSufix;

                RestClient client = new RestClient(URL);

                Request = new RestRequest(URL, Method.Post);

                //agregamos la info de la llave de seguridad (ApiKey) 
                Request.AddHeader(Services.APIConnection.ApiKeyName, Services.APIConnection.ApiKeyValue);
                Request.AddHeader(GlobalObjects.ContentType, GlobalObjects.MimeType);

                //En este caso tenemos que enviar un JSON al API con la data del usuario que se quiere
                //agregar
                string SerializedModel = JsonConvert.SerializeObject(this);

                Request.AddBody(SerializedModel, GlobalObjects.MimeType);

                //ejecución de la llamada al controlador 
                RestResponse response = await client.ExecuteAsync(Request);

                HttpStatusCode statusCode = response.StatusCode;

                if (statusCode == HttpStatusCode.Created)
                {
                    return true;
                }
                else
                {
                    return false;
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


        public async Task<List<Buy>> GetAllbuy()
        {
            try
            {
                string RouteSufix = string.Format("Buys");

                //con esto obtenemos la ruta completa de consumo del API 
                string URL = Services.APIConnection.ProductionURLPrefix + RouteSufix;

                RestClient client = new RestClient(URL);

                Request = new RestRequest(URL, Method.Get);

                //agregamos la info de la llave de seguridad (ApiKey) 
                Request.AddHeader(Services.APIConnection.ApiKeyName, Services.APIConnection.ApiKeyValue);
                Request.AddHeader(GlobalObjects.ContentType, GlobalObjects.MimeType);

                //ejecución de la llamada al controlador 
                RestResponse response = await client.ExecuteAsync(Request);

                HttpStatusCode statusCode = response.StatusCode;

                if (statusCode == HttpStatusCode.OK)
                {
                    //usamos newtonsoft para descomponer el paquete json que nos llega
                    //desde el API
                    var list = JsonConvert.DeserializeObject<List<Buy>>(response.Content);
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
