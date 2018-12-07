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


        public int chooseTable(int nbPlaces)
        {
            int idTable = 0;
            //int idTable = Requete.getTable(nbPlace);

            return idTable;


//            getTable(nbPlace){
//                  requête bdd :
//                  int idTable
//                  foreach response if  available and nbPlace >= nbPlace and    
//            }

        }

        public void callChefRRang(int idChefRang,int idTable)
        {
             
        }
            
        public void getPayment(int idGroup)
        {
          //  groupLeaves(id);

        }

        public void groupLeaves(int idGroup)
        {

        }

    }
}
