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


        private void Aceptar_Button(object sender, RoutedEventArgs e)
        {
            Window1 form = new Window1();
            form.ShowDialog();
        }

        private void Cancelar_Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow form = new MainWindow();
            form.ShowDialog();
        }



    }

}


