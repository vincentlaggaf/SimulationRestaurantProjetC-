using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public int chooseTable(int nbClientsInGroup)
        {
            TableController.GetTableController().MylistTable.ElementAt(0).MyAvailable = true;
            int i = 0;
            int tableId = 0;
            while (i < TableController.GetTableController().MylistTable.Count)
            {
                if (TableController.GetTableController().MylistTable.ElementAt(i).MyAvailable)
                {
                    if (TableController.GetTableController().MylistTable.ElementAt(i).MyNumberSeats >= nbClientsInGroup)
                    {
                        Console.WriteLine("table disponible à : " + TableController.GetTableController().MylistTable.ElementAt(i).MyIdTable);
                        tableId = TableController.GetTableController().MylistTable.ElementAt(i).MyIdTable;
                    }
                }

                i++;
            }
            return tableId;
        }
  

        public void callChefRang(int idTable)
        {
            if ((idTable == 1) || (idTable == 2))
            {
                for (int i = 0; i < StaffController.GetStaffController().MylistStaff.Count(); i++)
                    if (StaffController.GetStaffController().MylistStaff.ElementAt(i).ToString() == "ControleurRestaurant.ChefRang")
                    {
                        if (StaffController.GetStaffController().MylistStaff.ElementAt(i).returnID() == 1)
                        {
                            StaffController.GetStaffController().MylistStaff.ElementAt(i).doStuff(idTable);
                        }
                    }
            }
            if ((idTable == 3) || (idTable == 4))
            {
                for (int i = 0; i < StaffController.GetStaffController().MylistStaff.Count(); i++)
                    if (StaffController.GetStaffController().MylistStaff.ElementAt(i).ToString() == "ControleurRestaurant.ChefRang")
                    {
                        if (StaffController.GetStaffController().MylistStaff.ElementAt(i).returnID() == 2)
                        {
                            StaffController.GetStaffController().MylistStaff.ElementAt(i).doStuff(idTable);
                        }
                    }
            }
        }

         public void getPayment(int idTable)
        {
            int j = 0;
            int price =0;
            while (TableController.GetTableController().MylistTable.ElementAt(j).MyIdTable != idTable)
            {
                j++;
            }

            price = TableController.GetTableController().MylistTable.ElementAt(j).MyGroup.MyPrixTotal;
            Console.WriteLine("la table : "+ idTable + "a payé : " + price + "€");


           groupLeaves(idTable);

        }

        public void groupLeaves(int idTable)
        {

            for (int i = 0; i < StaffController.GetStaffController().MylistStaff.Count(); i++)
                if (StaffController.GetStaffController().MylistStaff.ElementAt(i).ToString() == "ControleurRestaurant.Serveur")
                {
                if (StaffController.GetStaffController().MylistStaff.ElementAt(i).getAvailability() == Availability.waiting)
                    {
                        StaffController.GetStaffController().MylistStaff.ElementAt(i).doStuff(idTable);
                    }
                }
        }


        public int returnID()
        {
            throw new NotImplementedException();
        }

        public void doStuff(int idTable)
        {
            throw new NotImplementedException();
        }

        public void doStuff2(int idTable, int idChefRang)
        {

            throw new NotImplementedException();
        }


        Availability IStaff.getAvailability()
        {
            return MyAvailability;
        }
    }
}