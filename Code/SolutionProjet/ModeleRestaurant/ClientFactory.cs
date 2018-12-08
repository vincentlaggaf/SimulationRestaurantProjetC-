using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeleRestaurant
{
    public class ClientFactory : IClientFactory
    {

        public Client GetClient(int i)
        {


            return new Client(i);
        }
    }
}
