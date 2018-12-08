using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeleRestaurant
{
    public interface IClient
    {
       
         void Command(int i);
        int getCommand();
    }
}
