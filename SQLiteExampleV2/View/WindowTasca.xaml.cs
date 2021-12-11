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
using SQLiteExampleV2.View;

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

        // Window_Loaded_Tasca
        public void Window_Loaded2(object sender, RoutedEventArgs e)
        {
            dgTasca.ItemsSource = TascaService.GetALL();

        }

        // AddTasca
        private void AddTasca(object sender, RoutedEventArgs e)
        {
            //Agafem les dades del item seleccionat
            Tasca oTasca = (Tasca)dgTasca.SelectedItem;
            //Li passem l'usuari seleccionat al formulari Edit
            WindowAfegirTasca w = new WindowAfegirTasca(oTasca);
            w.ShowDialog();
            dgTasca.ItemsSource = TascaService.GetALL();

        }
    }
}
