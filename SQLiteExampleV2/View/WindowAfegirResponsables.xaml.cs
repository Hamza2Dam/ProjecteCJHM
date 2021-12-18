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
    public partial class WindowAfegirResponsables : Window
    {

        User oUser;

        public WindowAfegirResponsables()
        {
            InitializeComponent();
        }

        public WindowAfegirResponsables(User user)
        {
            InitializeComponent();
            oUser = user;
            this.DataContext = user;
        }


        // Afegir Reponsable
        private void AfegirReponsable_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                UserService userService = new UserService();
                User r = new User();
                r.Name = Name.Text;
                r.LastName = LastName.Text;
                r.Birthday = (DateTime)Birthday.SelectedDate; 

                userService.Add(r);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
