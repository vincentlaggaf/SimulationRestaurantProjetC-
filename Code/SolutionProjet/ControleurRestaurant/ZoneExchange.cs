using System;
using System.Linq;
using System.Threading;

namespace ControleurRestaurant
{
    public class ZoneExchange
    {

        private static ZoneExchange instanceZoneExchange = null;
        private ZoneExchange()
        {

        }

        public static ZoneExchange GetZoneExchange()
        {
            if (instanceZoneExchange == null)
            {
                instanceZoneExchange = new ZoneExchange();
            }
            return instanceZoneExchange;
        }

        public void commandeComplete(int idTable)
        {
            TableController.GetTableController().MyManualResetEvent.WaitOne(Timeout.Infinite);
            Console.WriteLine("commande complète pour la table :" + idTable);
            for (int i = 0; i < StaffController.GetStaffController().MylistStaff.Count; i++){
                if (StaffController.GetStaffController().MylistStaff.ElementAt(i).ToString() == "ControleurRestaurant.Serveur"){
                    StaffController.GetStaffController().MylistStaff.ElementAt(i).doStuff(idTable);
                    break;
                }
            }
        }
    }
}