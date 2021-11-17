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

        private void txt_taskname1(object sender, TextChangedEventArgs e)
        {
        }

        private void txt_descripcio1(object sender, TextChangedEventArgs e)
        {
        }

        private void txt_responsable1(object sender, TextChangedEventArgs e)
        {
        }



        private void Aceptar_Button_Click(object sender, TextChangedEventArgs e)
        {
            MainWindow form = new MainWindow();
            form.ShowDialog();
        }

        private void Cancelar_Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow form = new MainWindow();
            form.ShowDialog();
        }



    }

}


