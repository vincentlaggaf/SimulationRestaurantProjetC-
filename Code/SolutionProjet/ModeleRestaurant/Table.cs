using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeleRestaurant
{
    public class Table
    {

       // public Table(){}

        private int idTable;

        public int MyIdTable
        {
            get { return idTable; }
            set { idTable = value; }
        }

        private int numberSeats;

        public int MyNumberSeats
        {
            get { return numberSeats; }
            set { numberSeats = value; }
        }

        private Group()
        {

        }

        Group group1 = new Group();

        private bool available;

        public bool MyAvailable
        {
            get { return available; }
            set { available = value; }
        }

        //public int getNumberSeat()
        //{

        //}

    }
}
