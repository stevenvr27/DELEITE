using DELEITE.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DELEITE.ViewModels
{
   public  class MainPageVM
    {
        public ObservableCollection<Items> cosas { get; set; }
        public MainPageVM()
        {
            cosas = new ObservableCollection<Items>
       {
         new Items
          {
             Name = "Brunchbox",
             Price =7000,
             Image = "Desayuno.jpg",
             HasOffer = false
          },

           new Items
          {
             Name = "Browniepizza",
             Price = 14000,
             Image = "queque.jpg" ,
             HasOffer = true,
             OfferPrice = 12000,
          },

            new Items
          {
             Name = "S'mores box",
             Price = 15,
             Image = "desayuno1.jpg",
             HasOffer = false
          },

           new Items
          {
             Name = "Donitas",
             Price = 12,
             Image = "donas.jpg",
             HasOffer = false
          },

           new Items
          {
             Name = "Ramos De Fresas",
             Price = 13,
             Image = "ramo.jpg",
             HasOffer = true,
             OfferPrice = 10
          },

           new Items
          {
             Name = "Cajitas De Desayuno",
             Price = 16,
             Image = "desayuno5.jpg",
             HasOffer = false

           }
   };


        }
    }
}
