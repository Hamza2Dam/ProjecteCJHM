using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

using SQLiteExampleV2.Persistence;
using SQLiteExampleV2.View;

namespace SQLiteExampleV2
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

        /// <summary>
        /// Evento que se ejecuta cuando se han dibujado los controles en la ventana
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_ContentRendered(object sender, EventArgs e)
        {
            DbContext.Up();

        }

        private void AfegirResponsable_Button_Click(object sender, RoutedEventArgs e)
        {
            WindowResponsables form = new WindowResponsables();
            form.ShowDialog();
        }

        private void AfegirTasca_Button_Click(object sender, RoutedEventArgs e)
        {
            WindowTasca form = new WindowTasca();
            form.ShowDialog();
        }


    }
}
