using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleurRestaurant
{
    class Restaurant
    {
        public void restaurant()
        {

            MaitreHotel maitreHotel = new MaitreHotel();
            int i = 0;
            int nbServeur = 5;
            while (i <= nbServeur)
                {
                Serveur serveur = new Serveur();
                serveur.MyId = i;
                i++;
                }
            //instanciation of all the objects
            //new staff
            //new zoneExchange
            //new table
            //new ustensil
            //new groupRandom
        }

    }


}
