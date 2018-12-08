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


        public int chooseTable(int nbClientsInGroup)
        {
            int i = 0;
            while ((TableController.GetTableController().MylistTable.ElementAt(i).MyNumberSeats < nbClientsInGroup)
                   &&
                   (TableController.GetTableController().MylistTable.ElementAt(i).MyAvailable)){
                i++;
            }

            //int idTable = Requete.getTable(nbPlace);
            return i;


//            getTable(nbPlace){
//                  requête bdd :
//                  int idTable
//                  foreach response if  available and nbPlace >= nbPlace and    
//            }

        }

        public void callChefRang(int idTable)
        {
            if ((idTable == 1) || (idTable == 2)){
                //faire STAFF CONTROLLER POUR POUVOIR APPELER CHEF DE RANG
                // appeler chef rang 1
                //ChefRang.dressTable()
            }

            if ((idTable == 3) || (idTable == 4))
            {
                // appeler chef rang 2
                //ChefRang.dressTable()
            }
        }
            
        public void getPayment(int idTable)
        {
            int j = 0;
            int price = 0;
            while (TableController.GetTableController().MylistTable.ElementAt(j).MyIdTable != idTable)
            {
                j++;
            }
           // TableController.GetTableController().MylistTable.ElementAt(j).getGroup();
            // get the group with the id

          //  int k = 0; 

          //  while (k<group.dishList.lenght){
          //       price += group.dishList.ElementAt(k).myPrice;    
          //  }
          //  groupLeaves(idGroup);

        }

        public void groupLeaves(int idGroup)
        {
            // passe à 1 l'availability, et passe à 0 l'id de la table dans la table du mcd 
        }

    }
}