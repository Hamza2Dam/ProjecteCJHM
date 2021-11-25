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

        private void AfegirResponsable_Button_Click(object sender, RoutedEventArgs e)
        {
            WindowResponsables form = new WindowResponsables();
            form.ShowDialog();
        }

        private void AfegirTasca_Button_Click(object sender, RoutedEventArgs e)
        {
            WindowTasca form = new WindowTasca();
            form.ShowDialog();
        }

        private void Window_Loaded3(object sender, RoutedEventArgs e)
        {

            lbOne.ItemsSource = TascaService.GetTODO();
            lbTwo.ItemsSource = TascaService.GetDOING();
            lbThree.ItemsSource = TascaService.GetDONE();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Tasca Moure = (Tasca)lbOne.Items[lbOne.SelectedIndex];
            Moure.Estat = "DOING";
            lbOne.ItemsSource = TascaService.GetTODO();
            lbTwo.ItemsSource = TascaService.GetDOING();
            lbThree.ItemsSource = TascaService.GetDONE();

        }
    }
}
