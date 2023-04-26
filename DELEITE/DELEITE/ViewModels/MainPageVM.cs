using DELEITE.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DELEITE.ViewModels
{
   public  class MainPageVM
    {
        public ObservableCollection<Items> productos { get; set; }
        public MainPageVM()
        {
            productos = new ObservableCollection<Items>
       {
         new Items
          {
             Name = "Brunch box",
             Price =7000,
             Image = "Desayuno.jpg",
             HasOffer = false
          },

           new Items
          {
             Name = "Brownie pizza",
             Price = 14000,
             Image = "queque.jpg" ,
             HasOffer = true,
             OfferPrice = 12000,
          },

   };


        }
    }
}
