using SQLiteExampleV2.Entity;
using SQLiteExampleV2.Service;
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
using System.Windows.Shapes;

namespace SQLiteExampleV2.View
{
    /// <summary>
    /// Interaction logic for WindowTasca.xaml
    /// </summary>
    public partial class WindowTasca : Window
    {
        public WindowTasca()
        {
            InitializeComponent();
        }

        private void Window_Loaded2(object sender, RoutedEventArgs e)
        {
            dgUsers.ItemsSource = UserService.GetAll();
        }

        private void dgTasca_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
