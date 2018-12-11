using System;
using System.Collections.Generic; using System.Linq; using System.Text; using System.Threading;
using System.Threading.Tasks; using System.Timers;
using ControleurRestaurant;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {    
            Restaurant restaurant = new Restaurant();
            restaurant.restaurant();
        }
    }
}
