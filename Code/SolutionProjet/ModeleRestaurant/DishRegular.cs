using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeleRestaurant
{
    public class DishRegular : AbstractDish
    {
       public DishRegular()
        {
            this.Name ="RegularDish";
            this.Price =5;
            this.Id = 1;
            this.PreparationTime = 25;
        }
        
        

    }
}
