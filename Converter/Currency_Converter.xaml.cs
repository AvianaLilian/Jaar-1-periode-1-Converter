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
using System.Text.RegularExpressions;

namespace Converter
{
    /// <summary>
    /// Interaction logic for Currency_Converter.xaml
    /// </summary>
    public partial class Currency_Converter : Page
    {
        private string koers;
        private string inputField;
        private string resultField;

        public Currency_Converter()
        {
            InitializeComponent();
        }

        private void Button_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }
        //private void HomeButton_MouseDown(object sender, MouseButtonEventArgs e)
        //{
        //    this.NavigationService.Navigate(new HomePage());
        //}

        //private void LengthButton_MouseDown(object sender, MouseButtonEventArgs e)
        //{
        //    this.NavigationService.Navigate(new Length_Converter());
        //}

        //private void AngleButton_MouseDown(object sender, MouseButtonEventArgs e)
        //{
        //    this.NavigationService.Navigate(new Angle_Converter());
        //}

        //private void HexadecimalButton_MouseDown(object sender, MouseButtonEventArgs e)
        //{
        //    this.NavigationService.Navigate(new Hexadecimal_Converter());
        //}

        //private void TemperatureButton_MouseDown(object sender, MouseButtonEventArgs e)
        //{
        //    this.NavigationService.Navigate(new Temperature_Converter());
        //}

        //private void WeightButton_MouseDown(object sender, MouseButtonEventArgs e)
        //{
        //    this.NavigationService.Navigate(new Weight_Converter());
        //}
        private void ComboBox_Input(object sender, SelectionChangedEventArgs e)
        {
            koers = Field_Value.Text;
        }

        private void ComboBox_Result(object sender, SelectionChangedEventArgs e)
        {
            inputField = Input_Field.Text;
            //checken wel combobox item is geselecteerd
            string content = ((ComboBoxItem)ComboBoxResult.SelectedItem).Content as string;
            if (content != null)
            {
                MessageBox.Show(content);
            }
            // fieldvalue in procenten dus als input 1 is en value 2 dan is result 1.02 want 1/100x102 = 1.02
            //optellen van procenten value op 100 
            //var result = (float)inputField / 100 * 100 + (float)koers;
            //if (result != null)
            //{
            //    MessageBox.Show(result);
            //}

            resultField = Result_Field.Text;
            //checken wel combobox item is geselecteerd
            koers = Field_Value.Text;
            //checken dat het niet leeg is
            //2 decimalen
            //geen text input

        }
        private void NumberValidation(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9.,]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
