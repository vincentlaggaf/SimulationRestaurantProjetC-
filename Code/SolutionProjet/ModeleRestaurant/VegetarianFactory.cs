using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeleRestaurant
{
   public class VegetarianFactory : IPlatFactory
    {
        public AbstractDish getDish()
        {
          //  Bdd.GetBddConnexion().SupressIngredient(2);
            return new DishVegetarian();
        }
    }
}
