using System;
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
        bool stop = true;

        private int waiters;

        public int MyWaiters
        {
            get { return waiters; }
            set { waiters = value; }
        }

        private int tables;

        public int MyTables
        {
            get { return tables; }
            set { tables = value; }
        }
        public void restaurant()
        {
            //Instiate the table controller
            TableController.GetTableController().createListTable(tables);
            //Instiate the Maitre d'Hotel
            StaffController.GetStaffController().addMaitreHotel(1);
            //Instiate all the chef de rang
            StaffController.GetStaffController().addChefRang(2);
            //Instiate all the waiters
            StaffController.GetStaffController().addServer(5);

            //Thread thread = new Thread(() =>{TableController.GetTableController().MyManualResetEvent.WaitOne(Timeout.Infinite);});
            Task task = Task.Factory.StartNew(() => clientArrival());

            while (true)
            {
                while (Console.ReadKey().KeyChar != 'a')
                {
                    Thread.Sleep(500);
                }
                if (stop == true)
                {
                    TableController.GetTableController().MyManualResetEvent.Reset();
                    stop = false;
                }
                else if (stop == false)
                {
                    TableController.GetTableController().MyManualResetEvent.Set();
                    stop = true;
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
        }
        public void clientArrival()
        {
            TableController.GetTableController().MyManualResetEvent.WaitOne(Timeout.Infinite);
            Group groupe = new Group();
            Console.WriteLine("j'ai accueilli un groupe de :" + groupe.MySizeGroup);

            int i = 0;
            while (StaffController.GetStaffController().MylistStaff.ElementAt(i).ToString() != "ControleurRestaurant.MaitreHotel")
            {
                i++;
            }

            Thread thread = new Thread(() =>
            {
                StaffController.GetStaffController().MylistStaff.ElementAt(i).doStuff3(groupe);
            });
            thread.Start();
            appelClients();
        }

        public void appelClients()
        {
            TableController.GetTableController().MyManualResetEvent.WaitOne(Timeout.Infinite);
            int time = rdn.Next(1, 5);
            Thread.Sleep(time * 2000);
            Console.WriteLine("un nouveau groupe arrive");
            clientArrival();
        }

    }
}