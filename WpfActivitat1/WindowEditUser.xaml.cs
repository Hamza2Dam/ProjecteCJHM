﻿using SQLiteWpfActivitat1.Entitats;
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
    public partial class WindowEditUser : Window
    {

        Responsable user;

        public WindowEditUser()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Creo un altre constructor on li passo l'objecte user del formulari  (es podria fer d'altres maneres
        /// com per exemple accedir a través d'una property
        /// </summary>
        /// <param name="user"></param>
        public WindowEditUser(Responsable user)
        {
            InitializeComponent();

            this.user = user;

            //Li estem dient amb que farà l'enllaç (quan fem el binding en el disseny) 
            this.DataContext = user;
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                UserService userService = new UserService();
                userService.Update(user);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
