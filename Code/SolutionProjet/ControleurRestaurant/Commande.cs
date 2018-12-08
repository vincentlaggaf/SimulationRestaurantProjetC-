using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleurRestaurant
{
    public class Commande
    {
        public double time;
        //private List<AbstractDish> dishList;
        private Group group;
        public void setCommande()
        {
            // group.getDishlist()
            // getPreparationTime();
            // startPreparation();
        }

        public double getPreparationTime()
        {
            // int i = 0;
            // int time = 0;
            // while (i<group.dishList.lenght){
            //      time += group.dishList.ElementAt(i).montempsdepreparation;    
            // }
            return time;
        }

        public void startPreparation(double time)
        {
            // using system threading task
        }

       
    }


}
