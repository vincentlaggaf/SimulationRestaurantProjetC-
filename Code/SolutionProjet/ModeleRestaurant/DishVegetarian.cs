using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeleRestaurant
{
    public class DishVegetarian : AbstractDish
    {
      

       public  DishVegetarian()
        {
            this.Name = "VegetarianDish";
            this.Price = 10;
            this.Id = 2;
            this.PreparationTime = 35;



        }

    }
}
