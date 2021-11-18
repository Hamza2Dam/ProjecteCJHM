using SQLiteWpfActivitat1.Entitats;
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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class WindowListBox : Window
    {

        public WindowListBox()
        {
            InitializeComponent();
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Enllacem el control visual amb les dades
            listViewUsers.ItemsSource = UserService.GetAll();
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            //Agafem les dades del item seleccionat
            var item = ((ListBoxItem)listViewUsers.ContainerFromElement((Button)sender)).Content;

            //Li passem l'usuari seleccionat al formulari Edit
            Responsable user = (Responsable)item;
            WindowEditUser w = new WindowEditUser(user);
            w.ShowDialog();
        }

    }
}

