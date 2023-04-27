using DELEITE.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DELEITE.ViewModels
{
    public class ToppingVM

    {
        public Topping mytop {get;set;}

        public ToppingVM()
        {
            mytop = new Topping();
        }

        public async Task<List<Topping>> gettop()
        {
            try
            {
                List<Topping> toppings = new List<Topping>();

                toppings = await mytop.ListTopping();
                if (toppings == null)
                {
                    return null;
                }
                else
                {
                    return toppings;
                }
            }
            catch (Exception)
            {

                throw;
            }

        }





    }
}
