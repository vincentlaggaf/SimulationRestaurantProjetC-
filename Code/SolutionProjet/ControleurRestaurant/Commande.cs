using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleurRestaurant
{
    class Commande
    {
        public double time;
        private List<AbstractDish> dishList;

        public void setCommande()
        {

        }

        public double getPreparationTime()
        {
        

            return time;

        }

        public void startPreparation(double time)
        {

        }
    }


}
