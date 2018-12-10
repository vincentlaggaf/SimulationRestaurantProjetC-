using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ModeleRestaurant;

namespace ControleurRestaurant
{
    public class Restaurant
    {
        Random rdn = new Random();

        public void restaurant()
        {

            //Instiate the table controller
            TableController.GetTableController().createListTable(4);

            //Instiate all the chef de rang
            StaffController.GetStaffController().addChefRang(2);

            //Instiate the Maitre d'Hotel
            StaffController.GetStaffController().addMaitreHotel(1);



            //Instiate all the waiters
            StaffController.GetStaffController().addServer(5);

            Task task = Task.Factory.StartNew(clientArrival);

            //while(true){ Console.WriteLine("avant maitre d'hotel"); Thread.Sleep(5000);}
        }

        public void clientArrival()
        {
            Group groupe = new Group();
            int i = 0;
            while (StaffController.GetStaffController().MylistStaff.ElementAt(i).ToString() != "ControleurRestaurant.MaitreHotel"){
                i++;
            }

            Task task = Task.Factory.StartNew(() => StaffController.GetStaffController().MylistStaff.ElementAt(i).doStuff3(groupe));
            Console.WriteLine("j'ai accueilli un groupe de :" + groupe.MySizeGroup);

            int time = rdn.Next(1, 5);
            Thread.Sleep(time * 10000);
            Console.WriteLine("un nouveau groupe arrive");
            clientArrival();
        }
    }
}