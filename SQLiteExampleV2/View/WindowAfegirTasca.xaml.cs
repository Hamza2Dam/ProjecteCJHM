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
    /// Interaction logic for WindowEditUser.xaml
    /// </summary>
    public partial class WindowAfegirTasca : Window
    {

        Tasca oTasca;

        public WindowAfegirTasca()
        {
            InitializeComponent();
        }

        public WindowAfegirTasca(Tasca tasca)
        {
            InitializeComponent();

            oTasca = tasca;
            this.DataContext = tasca;

        }

        // Afegir Tasca
        private void Afegir_Tascas(object sender, RoutedEventArgs e)
        {
            try
            {
                TascaService tascaService = new TascaService();
                Tasca t = new Tasca();

                t.Nom = Nom.Text;
                t.Descripcio = Descripcio.Text;
                User responsable = (User)Responsable.SelectedItem;
                t.Responsable = responsable.Name;
                t.Colors = Colors.Text;
                t.Data_Inici = (DateTime)Data_Inici.SelectedDate;
                t.Data_Final = (DateTime)Data_Final.SelectedDate;
                t.Estat = Estat.Text;

                tascaService.Add(t);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void Window_Loaded4(object sender, RoutedEventArgs e)
        {
            //Enllacem el control visual amb les dades
            Responsable.ItemsSource = UserService.GetAll();
        }


    }
}
