using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleurRestaurant
{
    public class Restaurant
    {
        public void restaurant()
        {
            //Instiate the Maitre d'Hotel
            MaitreHotel maitreHotel = new MaitreHotel();

            //Instiate all the waiters
            int i = 0;
            int nbServeur = 5;
            while (i < nbServeur) {
                Serveur serveur = new Serveur();
               
                serveur.MyId = i;
                i++;
                Console.WriteLine("ajout du serveur"+serveur.MyId);
             }



            //Instiate the Exchange area
            // A FAIRE

            //Instiate the table controller
            // A FAIRE

            //Instiate the ustensils
            // A FAIRE
        }

    }


}
