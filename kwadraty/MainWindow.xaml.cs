﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace kwadraty
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }



        private void Checkbox1_Checked(object sender, RoutedEventArgs e)
        {

            if (Checkbox1.IsChecked == true)
            {
                Rectangle1.Visibility = Visibility.Visible;
                Slider1.Visibility = Visibility.Visible;
                Scroll1.Visibility = Visibility.Visible;
            }
            else if (Checkbox1.IsChecked == false)
            {

                Rectangle1.Visibility = Visibility.Hidden;
                Slider1.Visibility = Visibility.Hidden;
                Scroll1.Visibility = Visibility.Hidden;
            }
        }

        private void Checkbox2_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Checkbox3_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Checkbox4_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Checkbox5_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Checkbox6_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Scroll_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }
    }
}



