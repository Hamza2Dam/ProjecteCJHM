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
    /// Lógica de interacción para Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
        }


        private void Btn_boton1_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        /*private void Button_Click(object sender, RoutedEventArgs e)
        {
            double.TryParse(txt_precio.Text, out double num);
            double.TryParse(txt_iva.Text, out double iva);
            double.TryParse(txt_pvp.Text, out double pvp);

            if (num <= 0)
            {
                MessageBox.Show("Porfavor Introduce Un Numero Valido!", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                iva = num * 0.15;
                pvp = num - iva;
                txt_iva.Text = iva.ToString();
                txt_pvp.Text = pvp.ToString();

            }*/

        }
    }

}
