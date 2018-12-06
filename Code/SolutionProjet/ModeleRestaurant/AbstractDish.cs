using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeleRestaurant
{
    public abstract class AbstractDish
    {
        private int preparationTime;
        private string name;
        private int price;
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }


        public int Price
        {
            get { return price; }
            set { price = value; }
        }


        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int PreparationTime
        {
            get { return preparationTime; }
            set { preparationTime = value; }
        }

    }
}
