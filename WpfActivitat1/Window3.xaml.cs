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

        private void Donar_alta_Click(object sender, RoutedEventArgs e)
        {
            Window4 form = new Window4();
            form.ShowDialog();
        }

        private void Modificar_Click(object sender, RoutedEventArgs e)
        {
            Window5 form = new Window5();
            form.ShowDialog();
        }

        private void Eliminar_Click(object sender, RoutedEventArgs e)
        {
            Window6 form = new Window6();
            form.ShowDialog();
        }

    }
}


