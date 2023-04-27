using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DELEITE.Models
{
   public  class UserDTO
    {
        public RestRequest Request { get; set; }

        public int UsuarioID { get; set; }
        public string? UsuarioNombre { get; set; } = null!;
        public string? PrimerNombre { get; set; } = null!;
        public string? Apellidos { get; set; } = null!;
        public string? Numero { get; set; }
        public string? Contrasennia { get; set; } = null!;
        public int contadordemalas { get; set; }
        public string? correorespaldo { get; set; } = null!;
        public string? trabajoDescripcion { get; set; }=null!;

        public int estadoId { get; set; }
        public int CiudadId { get; set; }
        public int RoleId { get; set; }

        public string? Ciudad { get; set; } = null!;
        public string? roles { get; set; } = null!;
        public string? estados { get; set; } = null!;

        //FUNCIONES
        public async Task<UserDTO> GetUserData(string email)
        {
            try
            {
                string RouteSufix = string.Format("Users/GetUserData?email={0}", email);

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
                    var list = JsonConvert.DeserializeObject<List<UserDTO>>(response.Content);

                    var item = list[0];

                    return item;
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
 