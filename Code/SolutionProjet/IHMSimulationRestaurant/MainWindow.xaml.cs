using ControleurRestaurant;
using System;
using System.Collections.Generic;
using System.Linq;
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



namespace IHMSimulationRestaurant
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Restaurant restaurant;

        public delegate void UpdateUi();

        public void UiTest()
        {
            // TextBox1.Text = x.ToString();
        }

        public MainWindow()
        {
            InitializeComponent();
            // TextBox1.Text = x.ToString();
            // Thread decrementthread = new Thread(Decrement);
            // decrementthread.Start();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            restaurant = new Restaurant();
            restaurant.MyWaiters = int.Parse(TextBoxWaiter.Text);
            restaurant.MyTables = int.Parse(TextBoxTables.Text);
            restaurant.restaurant();

        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {


            //while ()
            //{


            //    Thread.Sleep(1000);

            //    TextBox1.Dispatcher.Invoke(new UpdateUi(UiTest));
            //    //Dispatcher.Invoke(() => { TextBox1.Text = toto.ToString(); });
            //}
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
