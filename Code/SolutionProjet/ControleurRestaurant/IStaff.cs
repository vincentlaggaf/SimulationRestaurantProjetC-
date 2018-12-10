using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModeleRestaurant;

namespace ControleurRestaurant
{
    public interface IStaff
    {

        int returnID();

        void doStuff(int idTable);
        void doStuff2(int idTable);
        void doStuff3(Group group);
        //   void doStuff3(int idTable);

        Availability getAvailability();

    }




    public enum Availability {busy, waiting, helping};

}
