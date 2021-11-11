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
    /// Lógica de interacción para Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int.TryParse(txt_nombre.Text, out int num);


            if (num % 5 == 0)
            {
                txt_resultado.Text = "El nombre és múltiple de 5 ";

            }
            else
            {
                txt_resultado.Text = "El nombre NO és múltiple de 5! ";
            }

            {
                if (!txt_nombre.Text.All(Char.IsDigit))
                {
                    MessageBox.Show("Porfavor introduce un numero", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }

        }

        private void Txt_resultado_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void Txt_nombre_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }

}
