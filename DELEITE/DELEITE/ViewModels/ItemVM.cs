using DELEITE.Models;
using RestSharp;
using System.Collections.Generic;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace DELEITE.ViewModels
{
    public class ItemVM : BaseViewModel
    {
        public Models.Item ite {get; set;}
        public ItemVM()
        {
            ite = new Models.Item();
        }


        public async Task<List<Models.Item>> Getitems()
        {
            try
            {
                List<Models.Item> itemss = new List<Models.Item>();

                itemss = await ite.Getitems();

                if (itemss == null)
                {
                    return null;
                }
                else
                {
                    return itemss;
                }

            }
            catch (Exception)
            {

                throw;
            }

        }


    }
}