using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

using ControleurRestaurant;
using IHMSimulationRestaurant;


namespace Main
{
    class Program
    {
        static void Main()
        {

//            Thread t = new Thread(new ThreadStart(ThreadProc));
            Thread thread = new Thread(new ThreadStart(test));
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();

            //Restaurant restaurant = new Restaurant();
            //restaurant.restaurant();
        }
    //    public static void ThreadProc() {
    //    for (int i = 0; i < 10; i++) {
    //        Console.WriteLine("ThreadProc: {0}", i);
    //        // Yield the rest of the time slice.
    //        Thread.Sleep(0);
    //    }
    //}
        public static void test(){
            MainWindow mainWindow = new MainWindow();
            App app = new App();
            app.InitializeComponent();
            app.Run();

        }
    }
}
