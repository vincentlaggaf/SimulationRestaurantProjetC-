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
            setAttribute();
        }

        public void setAttribute()
        {

            //Dictionary<string, Object> dishAttribute = Bdd.GetBddConnexion().GetDish(2);
            //this.Name = dishAttribute["Nom"].ToString();
            //this.Price = (int)dishAttribute["Prix"];
            //this.Id = (int)dishAttribute["Id"];
            //this.PreparationTime = (int)dishAttribute["Preparation"];

            this.Name = "dishvege";
            this.Price = 15;
            this.Id = 2;
            this.PreparationTime = 35;

        }
    }
}
