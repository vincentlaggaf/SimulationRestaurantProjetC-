using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleurRestaurant
{
    public class Serveur : IStaff
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


        public void serveCommand(int idTable)
        {
            // récupère l'id du groupe afin de récuper la liste 
            // des plats servis et les afficher en console
            // déclenche un chrono pour déclencher cleanTable à la fin

            // CREER UNE CLASSE PERMETTANT DE CRÉER DES TIMERS, EN PASSANT LE TEMPS EN PARAMÈTRE DES INSTANCES
        }

        public void cleanTable(int idTable)
        {
            // il faut que cette méthode récupère le nombre de couverts et les libère en reremplissant la BDD
            // exemple table 4 places --> +4 fourchettes dans la BDD, +4 Couteaux, etc
            // de plus il faut setter la table à available
            // à l'appelle d'une méthode --> repas fini

        }

        public void serveWaterBread()
        {
            // booleen dans la Classe table, waterAndBread
            // setté à true --> au bout d'un laps de temps, il passe à false
            // --> EVENT : appelle cette méthode qui le re-set à true pendant un laps de temps
        }
    }
}
