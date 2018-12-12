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
            setAttribute();
            
        }
        

        public void setAttribute()
        {

            Dictionary<string, Object> dishAttribute = Bdd.GetBddConnexion().GetDish(1);
            this.Name = dishAttribute["Nom"].ToString();
            this.Price = (int)dishAttribute["Prix"];
            this.Id = (int)dishAttribute["Id"];
            this.PreparationTime = (int)dishAttribute["Preparation"];


       
        }

    }
}
