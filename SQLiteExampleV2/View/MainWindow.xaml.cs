using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using SQLiteExampleV2.Service;


using SQLiteExampleV2.Persistence;
using SQLiteExampleV2.View;
using SQLiteExampleV2.Entity;

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

        private void Window_ContentRendered(object sender, EventArgs e)
        {
            DbContext.Up();
        }

        // RESPONSABLE
        private void AfegirResponsable_Button_Click(object sender, RoutedEventArgs e)
        {
            WindowResponsables form = new WindowResponsables();
            form.ShowDialog();
            lbOne.ItemsSource = TascaService.GetTODO();
            lbTwo.ItemsSource = TascaService.GetDOING();
            lbThree.ItemsSource = TascaService.GetDONE();
        }

        // TASCAS
        private void AfegirTasca_Button_Click(object sender, RoutedEventArgs e)
        {
            WindowTasca form = new WindowTasca();
            form.ShowDialog();
            lbOne.ItemsSource = TascaService.GetTODO();
            lbTwo.ItemsSource = TascaService.GetDOING();
            lbThree.ItemsSource = TascaService.GetDONE();
        }

        // Window_Loaded_MAIN
        private void Window_Loaded_MAIN(object sender, RoutedEventArgs e)
        {

            lbOne.ItemsSource = TascaService.GetTODO();
            lbTwo.ItemsSource = TascaService.GetDOING();
            lbThree.ItemsSource = TascaService.GetDONE();

        }

        // Button_TODO_DOING
        private void Button_TODO_DOING(object sender, RoutedEventArgs e)
        {
            Tasca Moure = (Tasca)lbOne.Items[lbOne.SelectedIndex];
            Moure.Estat = "DOING";
            lbOne.ItemsSource = TascaService.GetTODO();
            lbTwo.ItemsSource = TascaService.GetDOING();
            lbThree.ItemsSource = TascaService.GetDONE();
        }

        // Button_DOING_TODO
        private void Button_DOING_TODO(object sender, RoutedEventArgs e)
        {

        }

        // Button_DOING_DONE
        private void Button_DOING_DONE(object sender, RoutedEventArgs e)
        {

        }

        // Button_DONE_DOING
        private void Button_DONE_DOING(object sender, RoutedEventArgs e)
        {

        }
    }
}
