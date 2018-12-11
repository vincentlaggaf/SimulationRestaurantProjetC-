
using System.Collections.Generic; using System.Linq; using System.Text; using System.Threading;
using System.Threading.Tasks; using System.Timers;
using ControleurRestaurant;
using ModeleRestaurant;
using System;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            Task[] tab = new Task[5];
           
            Restaurant restaurant = new Restaurant();
            restaurant.restaurant();

            Console.ReadKey();
        }
    }
}
