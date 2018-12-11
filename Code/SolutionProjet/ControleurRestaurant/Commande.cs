using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ModeleRestaurant;

namespace ControleurRestaurant
{
    public class Commande
    {
        public int idTableCommande;

        List<int> listeIdPlat = new List<int>();
        public int time;
        public Commande()
        {

        }

        public void setCommande(int idTable, List<AbstractDish> dishList)
        {
            TableController.GetTableController().MyManualResetEvent.WaitOne(Timeout.Infinite);
            idTableCommande = idTable;
            int i = 0;

            while (i < dishList.Count)
            {
                listeIdPlat.Add(dishList.ElementAt(i).Id);
                time += dishList.ElementAt(i).PreparationTime;
                i++;
            }
            startPreparation(idTable);
        }

        public void startPreparation(int idTable)
        {
            TableController.GetTableController().MyManualResetEvent.WaitOne(Timeout.Infinite);
            Console.WriteLine("début de la préparation de la commande pour la table :" + idTable);
            Thread.Sleep(time * 500);
            ZoneExchange.GetZoneExchange().commandeComplete(idTable);
        }
    }
}
