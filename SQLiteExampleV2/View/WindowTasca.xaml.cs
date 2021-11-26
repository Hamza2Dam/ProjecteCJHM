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

        // EditTasca
        private void EditTasca(object sender, RoutedEventArgs e)
        {
            Tasca oTasca = (Tasca)dgTasca.SelectedItem;
            WindowEditTasca w = new WindowEditTasca(oTasca);
            w.ShowDialog();
        }

        // DeleteTasca
        private void DeleteTasca(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("¿Eliminar Tasca  seleccionado?", "Eliminar", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    //Agafem les dades del item seleccionat
                    Tasca oTasca = (Tasca)dgTasca.SelectedItem;

                    //Eliminen usuari
                    TascaService oService = new TascaService();
                    oService.Delete(oTasca.Codi);

                    //Actualitzem dades del grid
                    dgTasca.ItemsSource = TascaService.GetALL();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void dgTasca_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
