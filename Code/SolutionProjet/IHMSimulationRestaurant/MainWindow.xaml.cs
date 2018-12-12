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

namespace IHMSimulationRestaurant
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {


        public MainWindow()
        {

        }


        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

            Thread thread = new Thread(() =>
            {
                Restaurant restaurant = new Restaurant();
                restaurant.restaurant();
            });
            thread.IsBackground = true;
            thread.Start();


            //System.Diagnostics.Process.Start("C:\\Users\\Emma\\source\\repos\\vincentlaggaf\\SimulationRestaurantProjetC-\\Code\\SolutionProjet\\Main\\bin\\Debug\\Main.exe");
             this.BTNlaunch.Visibility = Visibility.Hidden;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            ControleurRestaurant.TableController.GetTableController().MyManualResetEvent.Set();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ControleurRestaurant.TableController.GetTableController().MyManualResetEvent.Reset();
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


    }
}
