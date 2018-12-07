using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeleRestaurant
{
    class Client : IClient
    {
        int order;

        public int Command()
        {
            Random rnd = new Random();
            order = rnd.Next(1, 2);
            return order;
        }
    }
}
