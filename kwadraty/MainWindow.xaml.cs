using System;
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
        int count = 0;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Checkbox_Checked(object sender, RoutedEventArgs e)
        {
            //prog.Value = 0;

            foreach (CheckBox c in lstbx.Items)
            {
                if (c.GetType() == typeof(CheckBox))
                {
                    prog.Value = count++;
                }
            }
        }
        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            
            Slider s = sender as Slider;
            
            switch (s.Name)
            {
                case "Slider1":
                    break;
                case "Slider2":
                    break;
                case "Slider3":
                    break;
                case "Slider4":
                    break;
                case "Slider5":
                    break;
                case "Slider6":
                    break;

            }
        }

        private void Scroll1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }
    }
}



