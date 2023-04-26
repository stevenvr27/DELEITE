using DELEITE.APPMODELS;
using DELEITE.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace DELEITE.ViewModels
{
   public  class MainPageVM
    {
        public ObservableCollection<Products> cosas { get; set; }
        public MainPageVM()
        {
            cosas = new ObservableCollection<Products>
            
       {
         new Products
          {
             Name = "Brunchbox",
             Price =7000,
             Image = "Desayuno.jpg",
             HasOffer = false
          },

           new Products
          {
             Name = "Browniepizza",
             Price = 14000,
             Image = "queque.jpg" ,
             HasOffer = true,
             OfferPrice = 12000,
          },

            new Products
          {
             Name = "S'mores box",
             Price = 15,
             Image = "desayuno1.jpg",
             HasOffer = false
          },

           new Products
          {
             Name = "Donitas",
             Price = 12,
             Image = "donas.jpg",
             HasOffer = false
          },

           new Products
          {
             Name = "Ramos De Fresas",
             Price = 13,
             Image = "ramo.jpg",
             HasOffer = true,
             OfferPrice = 10
          },

           new Products
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
