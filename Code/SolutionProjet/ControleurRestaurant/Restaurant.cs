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
                serveur.MyId = i+1;
                Console.WriteLine("ajout du serveur : "+serveur.MyId);
                i++;
            }

            //Instiate the table controller
            TableController.GetTableController().createListTable(4);
            //TableController.GetTableController().MylistTable.ForEach(Console.WriteLine);
            int j = 0;
            while (j < TableController.GetTableController().MylistTable.Count)
            {
                Console.WriteLine("table id : "+ TableController.GetTableController().MylistTable.ElementAt(j).MyIdTable);
                j++;
            }


            //Instiate the Exchange area
            // A FAIRE

            //Instiate the ustensils
            // A FAIRE
        }

    }


}
