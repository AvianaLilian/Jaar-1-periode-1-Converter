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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Loaded += MyWindow_Loaded; //Zorgt ervoor dat zodra de window geladen is dat een pagina word geladen
        }

        private void MyWindow_Loaded(object sender, RoutedEventArgs e)
        {
            Frame.NavigationService.Navigate(new HomePage()); //Zet de Homepage in de main frame
        }
        private void BtnClickAngle(object sender, RoutedEventArgs e)
        {
            Main.Content = new Angle_Converter();
        }
        private void BtnClickLength(object sender, RoutedEventArgs e)
        {
            Main.Content = new Length_Converter();
        }
        private void BtnClickCurrency(object sender, RoutedEventArgs e)
        {
            Main.Content = new Currency_Converter();
        }
        private void BtnClickHexadecimal(object sender, RoutedEventArgs e)
        {
            Main.Content = new Hexadecimal_Converter();
        }
        private void BtnClickTemperature(object sender, RoutedEventArgs e)
        {
            Main.Content = new Temperature_Converter();
        }
        private void BtnClickWeight(object sender, RoutedEventArgs e)
        {
            Main.Content = new Weight_Converter();
        }
    }
}
