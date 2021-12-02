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
        Tasca oTasca;

        public MainWindow()
        {
            InitializeComponent();
        }

        public MainWindow(Tasca tasca)
        {
            InitializeComponent();

            oTasca = tasca;
            this.DataContext = tasca;
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
            DbContext.Up();
            lbOne.ItemsSource = TascaService.GetTODO();
            lbTwo.ItemsSource = TascaService.GetDOING();
            lbThree.ItemsSource = TascaService.GetDONE();

        }

        // Button_TODO_DOING
        private void Button_TODO_DOING(object sender, RoutedEventArgs e)
        {
            if (lbOne.SelectedItem != null) 
            {
                try
                {
                    //Agafem les dades del item seleccionat
                    Tasca oTasca = (Tasca)lbOne.SelectedItem;

                    // Actualitzem l'Estat De la tasca
                    TascaService oService = new TascaService();
                    oService.Update_Todo_Doing(oTasca.Codi);


                    //Actualitzem dades del ListBox 
                    lbOne.ItemsSource = TascaService.GetTODO();
                    lbTwo.ItemsSource = TascaService.GetDOING();
                    lbThree.ItemsSource = TascaService.GetDONE();

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        // Button_DOING_TODO
        private void Button_DOING_TODO(object sender, RoutedEventArgs e)
        {
            if (lbTwo.SelectedItem != null)
            {
                try
                {

                    //Agafem les dades del item seleccionat
                    Tasca oTasca = (Tasca)lbTwo.SelectedItem;

                    // Actualitzem l'Estat De la tasca
                    TascaService oService = new TascaService();
                    oService.Update_Doing_Todo(oTasca.Codi);

                    //Actualitzem dades del ListBox 
                    lbOne.ItemsSource = TascaService.GetTODO();
                    lbTwo.ItemsSource = TascaService.GetDOING();
                    lbThree.ItemsSource = TascaService.GetDONE();

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        // Button_DOING_DONE
        private void Button_DOING_DONE(object sender, RoutedEventArgs e)
        {
            if (lbTwo.SelectedItem != null)
            {
                try
                {

                    //Agafem les dades del item seleccionat
                    Tasca oTasca = (Tasca)lbTwo.SelectedItem;

                    // Actualitzem l'Estat De la tasca
                    TascaService oService = new TascaService();
                    oService.Update_Doing_Done(oTasca.Codi);

                    //Actualitzem dades del ListBox 
                    lbOne.ItemsSource = TascaService.GetTODO();
                    lbTwo.ItemsSource = TascaService.GetDOING();
                    lbThree.ItemsSource = TascaService.GetDONE();

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        // Button_DONE_DOING
        private void Button_DONE_DOING(object sender, RoutedEventArgs e)
        {
            if (lbThree.SelectedItem != null)
            {
                try
                {

                    //Agafem les dades del item seleccionat
                    Tasca oTasca = (Tasca)lbThree.SelectedItem;

                    // Actualitzem l'Estat De la tasca
                    TascaService oService = new TascaService();
                    oService.Update_Done_Doing(oTasca.Codi);

                    //Actualitzem dades del ListBox 
                    lbOne.ItemsSource = TascaService.GetTODO();
                    lbTwo.ItemsSource = TascaService.GetDOING();
                    lbThree.ItemsSource = TascaService.GetDONE();

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }



    }
}
