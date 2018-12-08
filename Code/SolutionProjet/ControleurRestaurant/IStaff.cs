using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleurRestaurant
{
    public interface IStaff
    {

        int returnID();

        void doStuff(int idTable);
        void doStuff2(int idTable, int idChefRang);

        Availability getAvailability();

    }




    public enum Availability {busy, waiting, helping};

}
