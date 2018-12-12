using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ModeleRestaurant;

namespace ControleurRestaurant
{
    public class ChefRang : IStaff
    {

        public ChefRang(){
         //   takeCommand(2);
        }
        private Availability availability;

        public Availability MyAvailability
        {
            get { return availability; }
            set { availability = value; }
        }



        private int id;

        public int MyId {
            get { return id; }
            set { id = value; }
        }


        public void takeCommand(int idTable) {
            TableController.GetTableController().MyManualResetEvent.WaitOne(Timeout.Infinite);
            Console.WriteLine("le chef de rang prend la commande de la table " + idTable);
            Commande commande = new Commande();        
            int i = 0;
            while (TableController.GetTableController().MylistTable.ElementAt(i).MyIdTable != idTable) {
                i++;
            }
           commande.setCommande(idTable, TableController.GetTableController().MylistTable.ElementAt(i).MyGroup.getDishList());
        }

        public void dressTable(int idTable) {
            TableController.GetTableController().MyManualResetEvent.WaitOne(Timeout.Infinite);
            // Console.WriteLine("dans dress table " + idTable);
            takeCommand(idTable);
            // EVENT quand maitre d'hotel fait choose table
            // il faut que cette méthode récupère le nombre de couverts et les soustrait à la BDD
            // amélioration : récupérer plutôt la taille du groupe
            // attente 5 min --> appelle méthode table ou group --> qui appelle takeCommande(idTable)
        }

        public int returnID() {
            TableController.GetTableController().MyManualResetEvent.WaitOne(Timeout.Infinite);
            return MyId;
        }

        public void doStuff(int idTable) {
            TableController.GetTableController().MyManualResetEvent.WaitOne(Timeout.Infinite);
            dressTable(idTable);
        }

        public void doStuff2(int idTable) {
            TableController.GetTableController().MyManualResetEvent.WaitOne(Timeout.Infinite);
        }
        Availability IStaff.getAvailability() {
            TableController.GetTableController().MyManualResetEvent.WaitOne(Timeout.Infinite);
            return MyAvailability;
        }

        public void doStuff3(Group group)
        {
            TableController.GetTableController().MyManualResetEvent.WaitOne(Timeout.Infinite);
            throw new NotImplementedException();
        }

        public int doStuff4()
        {
            throw new NotImplementedException();
        }
    }
}
