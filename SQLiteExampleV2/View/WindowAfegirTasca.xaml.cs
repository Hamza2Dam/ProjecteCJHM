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

        /// <summary>
        /// Creo un altre constructor on li passo l'objecte user del formulari  (es podria fer d'altres maneres
        /// com per exemple accedir a través d'una property
        /// </summary>
        /// <param name="user"></param>
        public WindowAfegirTasca(Tasca tasca)
        {
            InitializeComponent();

            oTasca = tasca;

            //Li estem dient amb que farà l'enllaç (quan fem el binding en el disseny) 
            this.DataContext = tasca;
        }

        private void btnUpdate_Click2(object sender, RoutedEventArgs e)
        {
            try
            {
                TascaService tascaService = new TascaService();
                tascaService.Update(oTasca);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
