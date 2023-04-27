using System;
using DELEITE.Models;
using System.Collections.Generic;
using System.Text;
using RestSharp;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace DELEITE.ViewModels
{
    public  class buyvm:BaseViewModel
    {
        public Buy MyBuy { get; set; }
        public buyvm()
        {
            MyBuy = new Buy();
        }
        public async Task<ObservableCollection<Buy>> Getlistbuy(int puserid)
        {
            if (IsBusy) return null;
            IsBusy = true;

            try
            {
                ObservableCollection<Buy> list = new ObservableCollection<Buy>();
                MyBuy.UserId = puserid;
                list = await MyBuy.GetBuyByUser();

                if (list == null)
                {
                    return null;
                }
                else
                {
                    return list;
                }

            }
            catch (Exception)
            {

                throw;
            }
        }



    }
}
