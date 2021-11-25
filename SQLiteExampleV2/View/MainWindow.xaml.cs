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

namespace SQLiteExampleV2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ListBox dragSource = null;

        //Els ObservableCollection s'utiltizen per notificar a l'enllaç quan s'ha afegit, eliminat o modificat un element
        //D'aquesta manera tant si 

        ObservableCollection<string> zoneList_2 = new ObservableCollection<string>();
        ObservableCollection<string> zoneList_3 = new ObservableCollection<string>();

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

        private void ListBox_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            //Obtenim la llista des d'on s'ha polsat 
            ListBox parent = (ListBox)sender;
            dragSource = parent;
            //Obtenim l'element seleccionat
            object data = GetDataFromListBox(dragSource, e.GetPosition(parent));

            if (data != null)
            {
                DragDrop.DoDragDrop(parent, data, DragDropEffects.Move);
            }
        }

        private static object GetDataFromListBox(ListBox source, Point point)
        {
            UIElement element = source.InputHitTest(point) as UIElement;
            if (element != null)
            {
                object data = DependencyProperty.UnsetValue;
                while (data == DependencyProperty.UnsetValue)
                {
                    data = source.ItemContainerGenerator.ItemFromContainer(element);

                    if (data == DependencyProperty.UnsetValue)
                    {
                        element = VisualTreeHelper.GetParent(element) as UIElement;
                    }

                    if (element == source)
                    {
                        return null;
                    }
                }

                if (data != DependencyProperty.UnsetValue)
                {
                    return data;
                }
            }

            return null;
        }

        private void ListBox_Drop(object sender, DragEventArgs e)
        {
            ListBox parent = (ListBox)sender;
            object data = e.Data.GetData(typeof(string));
            ((IList)dragSource.ItemsSource).Remove(data);
            ((IList)parent.ItemsSource).Add(data);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            lbTwo.Items.Add(lbOne.Items[lbOne.SelectedIndex]);
            lbOne.Items.RemoveAt(lbOne.SelectedIndex);

        }
    }
}
