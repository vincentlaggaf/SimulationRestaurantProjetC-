using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleurRestaurant
{
    class Serveur : IStaff
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


        public void serveCommand()
        {

        }

        public void cleanTable()
        {

        }

        public void serveWaterBread()
        {

        }
    }
}
