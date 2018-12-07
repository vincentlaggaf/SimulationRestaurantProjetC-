using System;
namespace ControleurRestaurant
{
    sealed class TableController
    {
      

        private static TableController instanceTableController = null;

        private TableController(){}

        public static TableController GetTableController()
        {
            if (instanceTableController == null)
            {
                instanceTableController = new TableController();
            }
            return instanceTableController;
        }      
    }
}
