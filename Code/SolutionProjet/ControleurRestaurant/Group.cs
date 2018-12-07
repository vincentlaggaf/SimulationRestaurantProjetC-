using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleurRestaurant
{

    public class Group
    {

        private int sizeGroup;

        private List<int> clientList = new List<int>();

        private List<string> dishList = new List<string>();

        public int createGroup
        {
            get { return sizeGroup; }
            set { sizeGroup = value; }
        }

        public void createClientList
        {
            get { return clientList; }
            
        }

        public void createDishList
        {
            get { return dishList; }

        }

    }
}