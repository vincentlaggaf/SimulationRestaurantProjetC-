using System;
using ModeleRestaurant;
using System.Collections.Generic;
using System.Threading;

namespace ControleurRestaurant
{
    public class TableController
    {


        private static TableController instanceTableController = null;

        private List<Table> listTable = new List<Table>();

        public List<Table> MylistTable
        {
            get { return listTable; }
            set { listTable = value; }
        }

        private ManualResetEvent manualResetEvent = new ManualResetEvent(true);
       
        public ManualResetEvent MyManualResetEvent
        {
            get { return manualResetEvent; }
            set { manualResetEvent = value; }
        }

        private TableController(){}

        public static TableController GetTableController()
        {
            if (instanceTableController == null)
            {
                instanceTableController = new TableController();
            }
            return instanceTableController;
        }

        public void createListTable(int nbTables)
        {
            // public List<Table> createListTable(int nbTables){
            int i = 0;
            while (i < nbTables){
                //Table table = new Table()
                //{
                //    MyIdTable = i + 1
                //};
                Table table = new Table();
                table.MyIdTable = i + 1;
                table.MyAvailable = true;
                table.MyNumberSeats = 4;
                listTable.Add(table);
                i++;
            }
        }
    }
}
