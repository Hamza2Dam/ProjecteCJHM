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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void VeureTasca_Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 form = new Window1();
            form.ShowDialog();
        }

        private void AfegirTasca_Button_Click(object sender, RoutedEventArgs e)
        {
            Window2 form = new Window2();
            form.ShowDialog();
        }

        private void AfegirResponsable_Button_Click(object sender, RoutedEventArgs e)
        {
            Window3 form = new Window3();
            form.ShowDialog();
        }

    }
}