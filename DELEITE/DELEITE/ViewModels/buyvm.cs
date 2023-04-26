using System;
using DELEITE.Models;
using System.Collections.Generic;
using System.Text;
using RestSharp;
using System.Threading.Tasks;

namespace DELEITE.ViewModels
{
    public  class buyvm:BaseViewModel
    {
        RestRequest request;
        public Buy Mybuy { get; set; }

        public buyvm()
        {
            Mybuy = new Buy();
        }
        public async Task<bool> Addbuy()
        {
            if (IsBusy) return false;
            IsBusy = true;

            try
            {
                 Mybuy.BuyId = 0;  
                 Mybuy.BuyDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                 Mybuy.BuyNumber = 0;
                 Mybuy.BuyNotes=null;
                 Mybuy.Active = true;
                Mybuy.UserId = GlobalObjects.LocalUser.IDUsuario;
                


              bool R = await Mybuy.Addbuynew();

                return R;

            }
            catch (Exception)
            {
                return false;
                throw;
            }
            finally
            {
                IsBusy = false;
            }



        }

       

    }
}
