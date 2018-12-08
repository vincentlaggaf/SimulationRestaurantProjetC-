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

            //Instiate the table controller
            TableController.GetTableController().createListTable(4);
            //TableController.GetTableController().MylistTable.ForEach(Console.WriteLine);
            int j = 0;
            while (j < TableController.GetTableController().MylistTable.Count)
            {
                Console.WriteLine("table id : " + TableController.GetTableController().MylistTable.ElementAt(j).MyIdTable);
                Console.WriteLine("disponibilité : " + TableController.GetTableController().MylistTable.ElementAt(j).MyAvailable);
                j++;
            }

            //Instiate the Maitre d'Hotel
            StaffController.GetStaffController().addMaitreHotel(1);

            //Instiate all the waiters
            StaffController.GetStaffController().addServer(5);

            //Instiate all the chef de rang
            StaffController.GetStaffController().addChefRang(2);

           

            //Instiate the Exchange area
            ZoneExchange zoneExchange = new ZoneExchange();


            //Instiate the ustensils
            // A FAIRE



        }

    }


}
