using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleurRestaurant
{
    public class ChefRang : IStaff
    {
        private Availability availability;

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


        public void takeCommand(int idTable)
        {
            Commande commande = new Commande();        
            int i = 0;
            while (TableController.GetTableController().MylistTable.ElementAt(i).MyIdTable != idTable)
            {
                i++;
            }
           // TableController.GetTableController().MylistTable.ElementAt(i).getGroup();


            Console.WriteLine("id : " + i);
            commande.setCommande();

        }





        public void dressTable(int idTable)
        {
            // EVENT quand maitre d'hotel fait choose table
            // il faut que cette méthode récupère le nombre de couverts et les soustrait à la BDD
            // amélioration : récupérer plutôt la taille du groupe
            // attente 5 min --> appelle méthode table ou group --> qui appelle takeCommande(idTable)
        }


        //CLASSE TIMER GENERAL, COMMANDE, WAITING --> METTRE DES VARIABLES POUR POUVOIR PASSER EN PARAMÈTRE
      

    }
}
