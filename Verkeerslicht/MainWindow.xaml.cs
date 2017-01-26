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

namespace Verkeerslicht
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

        private void Stop_Click(object sender, RoutedEventArgs e)
        {
            verkeerslichtrood.Opacity = 1;
            verkeerslichtoranje.Opacity = 0;
            ButtonOranje.IsEnabled = true;
            ButtonRood.IsEnabled = false;
        }

        private void Opgelet_Click(object sender, RoutedEventArgs e)
        {
            if (verkeerslichtgroen.Opacity == 1)
            {
                ButtonRood.IsEnabled = true;
                verkeerslichtgroen.Opacity = 0;
            }
            else
            {
                ButtonGroen.IsEnabled = true;
                verkeerslichtrood.Opacity = 0;
            }
            verkeerslichtoranje.Opacity = 1;
            ButtonOranje.IsEnabled = false;
        }

        private void Go_Click(object sender, RoutedEventArgs e)
        {
            verkeerslichtgroen.Opacity = 1;
            verkeerslichtoranje.Opacity = 0; 
            ButtonGroen.IsEnabled = false;
            ButtonOranje.IsEnabled = true;
        }
    }
}
