﻿using ControleurRestaurant;
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

        public MainWindow()
        {
            InitializeComponent();

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
