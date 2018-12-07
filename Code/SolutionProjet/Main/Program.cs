using System; using System.Collections.Generic; using System.Linq; using System.Text; using System.Threading.Tasks; using ControleurRestaurant;
using ModeleRestaurant;

namespace Main {
    class Program
    {
        static void Main(string[] args)
        {
            Restaurant restaurant = new Restaurant();
            restaurant.restaurant(); 
        }
    } }