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
             Des = "Escogela a tu gusto ",
             Image = "Desayuno.jpg",
             HasOffer = false
          },

           new Products
          {
             Name = "Browniepizza",
             
             Image = "queque.jpg" ,
            
             Des = "Podes armarla como gustes  ",
          },

            new Products
          {
             Name = "S'mores box",
               Image = "desayuno1.jpg",
             Des = "Crugiente echa con mucho amor para ti ",
             HasOffer = false
          },

           new Products
          {
             Name = "Donitas",
              Des = " Pqueñas con muhco sabor",
             Image = "donas.jpg",
             HasOffer = false
          },

           new Products
          {
             Name = "Ramos De Fresas",
             Des = "Regala detalles que enamoran ",
             Image = "ramo.jpg",
             HasOffer = true 
          },

           new Products
          {
             Name = "Cajitas De Desayuno",
               Des = "Podes armarla como gustes  " ,
             Image = "desayuno5.jpg",
             HasOffer = false
           }
            };
        }

       
       


    }
}
