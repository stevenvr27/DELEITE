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
