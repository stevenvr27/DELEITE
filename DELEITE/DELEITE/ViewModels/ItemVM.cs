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


        public async Task<List<Item>> Getitem()
        {
            try
            {
                List<Item> items = new List<Item>();

                items = await ite.Listitems();
                if (items == null)
                {
                    return null;
                }
                else
                {
                    return items;
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

    }
}