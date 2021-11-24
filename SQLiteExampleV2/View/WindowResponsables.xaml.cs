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
    /// Interaction logic for WindowDataGrid.xaml
    /// </summary>
    public partial class WindowResponsables : Window
    {

        public WindowResponsables()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            dgUsers.ItemsSource = UserService.GetAll();
        }
        private void AfegirUsuari(object sender, RoutedEventArgs e)
        {
            //Agafem les dades del item seleccionat
            User oUser = (User)dgUsers.SelectedItem;
            //Li passem l'usuari seleccionat al formulari Edit
            WindowModificarResponsables w = new WindowModificarResponsables(oUser);
            w.ShowDialog();
        }

        private void ModificarUsuari(object sender, RoutedEventArgs e)
        {
            //Agafem les dades del item seleccionat
            User oUser = (User)dgUsers.SelectedItem;
            //Li passem l'usuari seleccionat al formulari Edit
            WindowModificarResponsables w = new WindowModificarResponsables(oUser);
            w.ShowDialog();
        }

        private void EliminarUsuari(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("¿Eliminar usuario seleccionado?", "Eliminar", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    //Agafem les dades del item seleccionat
                    User oUser = (User)dgUsers.SelectedItem;

                    //Eliminen usuari
                    UserService oService = new UserService();
                    oService.Delete(oUser.Id);

                    //Actualitzem dades del grid
                    dgUsers.ItemsSource = UserService.GetAll();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void dgUsers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
