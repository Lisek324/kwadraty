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

        private void Scroll1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
             
        }

        private void lstbx_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            prog.Value = 0;
            foreach (var c in lstbx.SelectedItems)
                {
                    prog.Value++;
                }
        }
    }
}



