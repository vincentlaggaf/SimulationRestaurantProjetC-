using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeleRestaurant
{
   public class RegularFactory : IPlatFactory
    {
        
        public AbstractDish getDish()
        {
          
          //  Bdd.GetBddConnexion().SupressIngredient(1);
            return new DishRegular();
        }
        
    }
}
