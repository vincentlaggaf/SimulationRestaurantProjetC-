using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeleRestaurant
{
    public class Table
    {

        public Table(){}

        private Group group;
        private int idTable;
        private bool waterAndBread;
        private int numberSeats;
        private bool available;

        public Group MyGroup
        {
            get { return group; }
            set { group = value; }
        }

        public int MyIdTable
        {
            get { return idTable; }
            set { idTable = value; }
        }

        public bool MyWaterAndBread
        {
            get { return waterAndBread; }
            set { waterAndBread = value; }
        }


        public int MyNumberSeats
        {
            get { return numberSeats; }
            set { numberSeats = value; }
        }

        public bool MyAvailable
        {
            get { return available; }
            set { available = value; }
        }


    }
}
