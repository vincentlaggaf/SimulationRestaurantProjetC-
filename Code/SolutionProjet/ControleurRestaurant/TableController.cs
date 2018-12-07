using System;
using ModeleRestaurant;
using System.Collections.Generic;

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
                Table table = new Table
                {
                    MyIdTable = i+1
                };
                listTable.Add(table);
                i++;
            }

           // return listTable;
        }

       

    }
}
