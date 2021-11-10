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


namespace WpfActivitat1
{
    /// <summary>
    /// Lógica de interacción para Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        public Window4()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double.TryParse(num_1.Text, out double num1);
            double.TryParse(num_2.Text, out double num2);

            if (!num_1.Text.All(Char.IsDigit) || !num_2.Text.All(Char.IsDigit))
            {
                MessageBox.Show("Porfavor introduce un numero", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            double Area = num1 * num2;
            txt_resultado.Text = Area.ToString();
        }

        private void Btn_boton2_Click(object sender, RoutedEventArgs e)
        {
            double.TryParse(num_1.Text, out double num1);
            double.TryParse(num_2.Text, out double num2);

            if (!num_1.Text.All(Char.IsDigit) || !num_2.Text.All(Char.IsDigit))
            {
                MessageBox.Show("Porfavor introduce un numero", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            double perimetre = (2*num1) + (2*num2);
            txt_resultado.Text = perimetre.ToString();
        }

        private void Btn_boton3_Click(object sender, RoutedEventArgs e)
        {
            double.TryParse(num_1.Text, out double num1);
            double.TryParse(num_2.Text, out double num2);

            if (!num_1.Text.All(Char.IsDigit) || !num_2.Text.All(Char.IsDigit) )
            {
                MessageBox.Show("Porfavor introduce un numero", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            double radi = Math.Sqrt( ( (num1*num1) + (num2*num2) ) /2 );
            txt_resultado.Text = radi.ToString();
        }

        private void Btn_boton4_Click(object sender, RoutedEventArgs e)
        {
            double.TryParse(num_1.Text, out double num1);
            double.TryParse(num_2.Text, out double num2);

            if (!num_1.Text.All(Char.IsDigit) || !num_2.Text.All(Char.IsDigit))
            {
                MessageBox.Show("Porfavor introduce un numero", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            double diagonal = Math.Sqrt((num1 * num1) + (num2 * num2));
            txt_resultado.Text = diagonal.ToString();
        }
    }

}
