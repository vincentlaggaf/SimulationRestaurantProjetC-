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

        public int MySizeGroup
        {
            get { return sizeGroup; }
            set { sizeGroup = value; }
        }

        private List<int> clientList = new List<int>();

        public void GetMyClientList()
        { clientList.Add(GetClient); }

        //sizeGroup = clientList.Count;

        public CreateGroup(int sizeGroup)
        {
            sizeGroup = clientList;

        }

        private List<string> dishList = new List<string>();


        // RegularFactory regularFactory = new RegularFactory();
        // VegetarianFactory vegetarianFactory = new VegetarianFactory();


        public void GetCreateDishList()
        { dishList.Add(); }

    }
}