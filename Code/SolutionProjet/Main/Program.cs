using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleurRestaurant;
using ModeleRestaurant;
using ConsoleApp3;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
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