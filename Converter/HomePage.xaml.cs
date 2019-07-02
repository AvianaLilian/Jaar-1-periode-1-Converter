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

namespace Converter
{
    /// <summary>
    /// Interaction logic for HomePage.xaml
    /// </summary>
    public partial class HomePage : Page
    {
        public HomePage()
        {
            InitializeComponent();
        }
        private void Angle_MouseDown(object sender, MouseEventArgs e)
        {
            this.NavigationService.Navigate(new Angle_Converter());
        }

        private void Length_MouseDown(object sender, MouseEventArgs e)
        {
            this.NavigationService.Navigate(new Length_Converter());
        }

        private void Currency_MouseDown(object sender, MouseEventArgs e)
        {
            this.NavigationService.Navigate(new Currency_Converter());
        }

       private void Hexadecimal_MouseDown(object sender, MouseEventArgs e)
        {
            this.NavigationService.Navigate(new Hexadecimal_Converter());
        }

        private void Temperature_MouseDown(object sender, MouseEventArgs e)
        {
            this.NavigationService.Navigate(new Temperature_Converter());
        }

        private void Weight_MouseDown(object sender, MouseEventArgs e)
        {
            this.NavigationService.Navigate(new Weight_Converter());
        }
    }
}
