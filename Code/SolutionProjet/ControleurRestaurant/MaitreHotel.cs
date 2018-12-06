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
            //  return idTable;
            return 0;
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
