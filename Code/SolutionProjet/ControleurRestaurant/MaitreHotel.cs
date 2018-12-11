using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ModeleRestaurant;

namespace ControleurRestaurant
{
    public class MaitreHotel : IStaff
    {
        private Availability availability;

        public Availability MyAvailability
        {
            get { return availability; }
            set { availability = value; }
        }

        List<int> listeTable = new List<int>();

        public MaitreHotel()
        {
        }

        public void chooseTable(Group group)
        {
            TableController.GetTableController().MyManualResetEvent.WaitOne(Timeout.Infinite);
             Thread.Sleep(2000);
            int placeTableListe = 0;
            int tableId = 0;
            bool test = false;

            for (int i = 0; (i < TableController.GetTableController().MylistTable.Count) && (test == false); i++)
            {
                if (TableController.GetTableController().MylistTable.ElementAt(i).MyAvailable && (TableController.GetTableController().MylistTable.ElementAt(i).MyNumberSeats >= group.MySizeGroup))
                {
                    tableId = TableController.GetTableController().MylistTable.ElementAt(i).MyIdTable;
                    placeTableListe = i;
                    test = true;
                }
            }

            if (test == false)
            {
                Console.WriteLine("pas de table dispo");
                Thread.Sleep(5000);
                chooseTable(group);
            }

            TableController.GetTableController().MylistTable.ElementAt(placeTableListe).MyGroup = group;
            Console.WriteLine("les clients vont occuper la table :" + tableId);
            TableController.GetTableController().MylistTable.ElementAt(placeTableListe).MyAvailable = false;
            callChefRang(tableId);
        }


        public void callChefRang(int idTable)
        {
            TableController.GetTableController().MyManualResetEvent.WaitOne(Timeout.Infinite);
            if ((idTable == 1) || (idTable == 2)){
                for (int i = 0; i < StaffController.GetStaffController().MylistStaff.Count(); i++){
                    if (StaffController.GetStaffController().MylistStaff.ElementAt(i).ToString() == "ControleurRestaurant.ChefRang"){
                        if (StaffController.GetStaffController().MylistStaff.ElementAt(i).returnID() == 1){
                            Console.WriteLine("j'appelle chef rang :" + StaffController.GetStaffController().MylistStaff.ElementAt(i).returnID()+ "pour la table :" + idTable);
                            StaffController.GetStaffController().MylistStaff.ElementAt(i).doStuff(idTable);
                        }
                    }
                }
            }

            if ((idTable == 3) || (idTable == 4)){
                for (int i = 0; i < StaffController.GetStaffController().MylistStaff.Count(); i++){
                    if (StaffController.GetStaffController().MylistStaff.ElementAt(i).ToString() == "ControleurRestaurant.ChefRang"){
                        if (StaffController.GetStaffController().MylistStaff.ElementAt(i).returnID() == 2){
                            Console.WriteLine("j'appelle chef rang :" + StaffController.GetStaffController().MylistStaff.ElementAt(i).returnID() + "pour la table :" + idTable);
                            StaffController.GetStaffController().MylistStaff.ElementAt(i).doStuff(idTable);
                        }
                    }
                }
            }
        }

        public void getPayment(int idTable){
            TableController.GetTableController().MyManualResetEvent.WaitOne(Timeout.Infinite);
            int j = 0;
            int price = 0;
            while (TableController.GetTableController().MylistTable.ElementAt(j).MyIdTable != idTable){
                j++;
            }

            price = TableController.GetTableController().MylistTable.ElementAt(j).MyGroup.MyPrixTotal;
            Console.WriteLine("la table : " + idTable + "a payé : " + price + "€");

          groupLeaves(idTable);

        }

        public void groupLeaves(int idTable)
        {
            TableController.GetTableController().MyManualResetEvent.WaitOne(Timeout.Infinite);
            Console.WriteLine("le groupe de la table " + idTable + " part");
            for (int i = 0; i < StaffController.GetStaffController().MylistStaff.Count; i++)
                if (StaffController.GetStaffController().MylistStaff.ElementAt(i).ToString() == "ControleurRestaurant.Serveur")
                {
                    if (StaffController.GetStaffController().MylistStaff.ElementAt(i).getAvailability() == Availability.waiting)
                    {
                        StaffController.GetStaffController().MylistStaff.ElementAt(i).doStuff2(idTable);
                        break;
                    }
                }
        }


        public int returnID(){
            TableController.GetTableController().MyManualResetEvent.WaitOne(Timeout.Infinite);
            throw new NotImplementedException();
        }

        public void doStuff(int nbPersonneGroupe){
            TableController.GetTableController().MyManualResetEvent.WaitOne(Timeout.Infinite);
            // chooseTable(nbPersonneGroupe);
        }
        public void doStuff2(int idTable){
            TableController.GetTableController().MyManualResetEvent.WaitOne(Timeout.Infinite);
            getPayment(idTable);
        }

        public void doStuff3(Group group){
            TableController.GetTableController().MyManualResetEvent.WaitOne(Timeout.Infinite);
            chooseTable(group);
        }

        Availability IStaff.getAvailability(){
            TableController.GetTableController().MyManualResetEvent.WaitOne(Timeout.Infinite);
            return MyAvailability;
        } 
    }
}