using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using ControleurRestaurant;
using ModeleRestaurant;

namespace IHMSimulationRestaurant
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        int prixTotal = 0;

        public MainWindow()
        {
            InitializeComponent();
           

        }


        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            int tables = Int32.Parse(LBLTables.Text);
            int waiters = Int32.Parse(LBLWaiters.Text);
            Thread thread = new Thread(() =>
            {
                Restaurant restaurant = new Restaurant();
                restaurant.MyTables = tables;
                restaurant.MyWaiters = waiters;
                restaurant.restaurant();

            });



            thread.IsBackground = true;
            thread.Start();
            Thread.Sleep(2000);
            Task.Factory.StartNew(() => refreshPrice());
            // Thread threadPrice = new Thread(() => refreshPrice());
            //threadPrice.IsBackground = true;
            //threadPrice.Start();


          //  threadPrice.IsBackground = true;
            //threadPrice.Start();
            
            //System.Diagnostics.Process.Start("C:\\Users\\Emma\\source\\repos\\vincentlaggaf\\SimulationRestaurantProjetC-\\Code\\SolutionProjet\\Main\\bin\\Debug\\Main.exe");
            this.BTNLaunch.Visibility = Visibility.Hidden;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            ControleurRestaurant.TableController.GetTableController().MyManualResetEvent.Set();

           



        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            TBXData.Clear();
            TBXDataCommande.Clear();
            



            ControleurRestaurant.TableController.GetTableController().MyManualResetEvent.Reset();
            for (int i = 0; i < TableController.GetTableController().MylistTable.Count; i++)
            {
                if (TableController.GetTableController().MylistTable.ElementAt(i).MyAvailable == true)
                {
                    TBXData.AppendText("La table " + TableController.GetTableController().MylistTable.ElementAt(i).MyIdTable + " est libre\n");
                }
                else
                {
                    TBXData.AppendText("La table " + TableController.GetTableController().MylistTable.ElementAt(i).MyIdTable + " est occupée par : " + TableController.GetTableController().MylistTable.ElementAt(i).MyGroup.MySizeGroup + " personnes \n");
                    TBXDataCommande.AppendText("La table " + TableController.GetTableController().MylistTable.ElementAt(i).MyIdTable + " a commandé : \n");
                    for (int j = 0; j < TableController.GetTableController().MylistTable.ElementAt(i).MyGroup.getDishList().Count; j++)

                        TBXDataCommande.AppendText("- "+TableController.GetTableController().MylistTable.ElementAt(i).MyGroup.getDishList().ElementAt(j).Name + "\n");
                }

            }






        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void DataGrid_SelectionChanged1(object sender, SelectionChangedEventArgs e)
        {

        }

        private void DataGrid_SelectionChanged2(object sender, SelectionChangedEventArgs e)
        {

        }

        private void DataGrid_SelectionChanged3(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {


        }
        public void refreshPrice()
        {






            while (true)
            {





                Dispatcher.BeginInvoke(new Action(() =>
                {

                    int k = 0;
                    while (StaffController.GetStaffController().MylistStaff.ElementAt(k).ToString() != "ControleurRestaurant.MaitreHotel")
                    {
                        k++;
                    }
                    prixTotal = StaffController.GetStaffController().MylistStaff.ElementAt(k).doStuff4();





                    TBKPrice.Text = "Gain totaux \n du restaurant : \n" + prixTotal.ToString() + "€";
                }), DispatcherPriority.Background);
                Thread.Sleep(1000);
            }




        }

        private void TextBox_TextChanged_3(object sender, TextChangedEventArgs e)
        {

        }
    }
}

