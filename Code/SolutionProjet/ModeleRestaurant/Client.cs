using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeleRestaurant
{
    public  class Client : IClient
    {
        
        private int order;
        
        public int Order
        {
            get { return order; }
            set { order = value; } 
        }

        public Client(int i)
        {

           
            Command(i);
        }
        public void Command(int i)
        {

            
            Order = i;
        
        }

        public int getCommand()
        {
           return Order;
        }
    }
}
