<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
=======
﻿//using System; using System;
using System.Collections.Generic; using System.Linq; using System.Text; using System.Threading.Tasks; using System.Timers;
>>>>>>> eb2cf2e... - Changing Group from Controller to Model - Filling methods for Server, MaitreHotel, chefRang - Creating methods for Table
using ControleurRestaurant;
using ModeleRestaurant;
using ConsoleApp3;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
            //Restaurant restaurant = new Restaurant();
            //restaurant.restaurant();

            IClientFactory clientFact = new ClientFactory();
            //Client toto = clientFact.GetClient();
            //Client test = clientFact.GetClient();
            Client[] clientab = new Client[10];
            Random rdn = new Random();
            for (int i = 0; i < clientab.Length; i++)
            {
                int k = rdn.Next(1, 3);
                clientab[i] = clientFact.GetClient(k);

            }

            for (int i = 0; i < clientab.Length; i++)
            {
                Console.WriteLine(clientab[i].Order);

            }
            //---------------BDD TEST---------------\\
            //Bdd bdd = new Bdd();
            //bdd.SupressIngredient(2);
            ////bdd.CheckTable(4);

            //Console.ReadKey();
            //---------------------------------------\\


        }
    }
}
=======
            Restaurant restaurant = new Restaurant();
            restaurant.restaurant();


            //System.Timers.Timer aTimer = new System.Timers.Timer();             //aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);             //aTimer.Interval = 5000;             //aTimer.Enabled = true;              //Console.WriteLine("Press \'q\' to quit the sample.");         }

        // Specify what you want to happen when the Elapsed event is raised.
        //private static void OnTimedEvent(object source, ElapsedEventArgs e)         //{         //    Console.WriteLine("Hello World!");         //}

    }
    } 
>>>>>>> eb2cf2e... - Changing Group from Controller to Model - Filling methods for Server, MaitreHotel, chefRang - Creating methods for Table
