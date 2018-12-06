using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleurRestaurant
{
    class ChefRang : IStaff
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

        public void takeCommand(List <IDish> dishlist)
        {

        }

    }
}
