using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using ModeleRestaurant;

namespace ControleurRestaurant
{
    public class Serveur : IStaff
    {
        private Availability availability = Availability.waiting;
        public Availability MyAvailability
        {
            get { return availability; }
            set { availability = value; }
        }

        private int id;
        public int MyId

        {
            get { return id; }
            set { id = value; }
        }


        public void serveCommand(int idTable)
        {

            Console.WriteLine("Les clients sont servis à la table :" + idTable);
            Thread.Sleep(10000);

            callMaitreHotel(idTable);
        }


        public void callMaitreHotel(int idTable)
        {
            Console.WriteLine("Les clients vont payer" + idTable);

            int indexMaitreHotel = 0;
            bool test = false;

            for (int i = 0; (i < StaffController.GetStaffController().MylistStaff.Count) && (test == false); i++)
            {
                if (StaffController.GetStaffController().MylistStaff.ElementAt(i).ToString() == "ControleurRestaurant.MaitreHotel")
                {
                    test = true;
                    indexMaitreHotel = i;
                }
            }

           
            if (test == false)
            {
                Console.WriteLine("le maitre d'hotel est occupé");
                Thread.Sleep(10000);
                callMaitreHotel(idTable);
            }

            StaffController.GetStaffController().MylistStaff.ElementAt(indexMaitreHotel).doStuff2(idTable);
        }

        public void cleanTable(int idTable)
        {

            Console.WriteLine("le serveur va nettoyer la table : " + idTable);
            // il faut que cette méthode récupère le nombre de couverts et les libère en reremplissant la BDD
            // exemple table 4 places --> +4 fourchettes dans la BDD, +4 Couteaux, etc

            int k = 0;
            while (TableController.GetTableController().MylistTable.ElementAt(k).MyIdTable != idTable)
            {
                k++;
            }

            TableController.GetTableController().MylistTable.ElementAt(k).MyAvailable = true;

        }

        public void serveWaterBread()
        {
            // booleen dans la Classe table, waterAndBread
            // setté à true --> au bout d'un laps de temps, il passe à false
            // --> EVENT : appelle cette méthode qui le re-set à true pendant un laps de temps
        }

        public int returnID()
        {
            return MyId;
            // throw new NotImplementedException();
        }

        public void doStuff(int idTable)
        {
            serveCommand(idTable);
        }

        public void doStuff2(int idTable)
        {
            cleanTable(idTable);
        }

        public void doStuff3(Group group)
        {
        }

        Availability IStaff.getAvailability()
        {
            return MyAvailability;
        }

    }
}