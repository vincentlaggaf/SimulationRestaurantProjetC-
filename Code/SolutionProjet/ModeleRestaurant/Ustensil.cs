using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeleRestaurant
{
    public class Ustensil
    {
        private bool available;

        public bool Available
        {
            get { return available; }
            set { available = value; }
        }

        public enum UstensilType { plate, fork, knife,spoon,glass };
    }
}
