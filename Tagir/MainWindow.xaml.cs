﻿using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Tagir.Class;

namespace Tagir
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ClassConnect.Ent = new tagirEntities1();

        }
        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            {
                if (Pass.Password.Length > 0)
                {
                    Watermack.Visibility = Visibility.Collapsed;
                }
                else
                {
                    Watermack.Visibility = Visibility.Visible;
                }
            }
        }
        private void Login()
        {

            try
            {
                if (ClassConnect.Ent.Admin.ToList().Where(i => i.Login == log.Text && i.Pass == Pass.Password.ToString()).Count() > 0)
                {
                    var user = ClassConnect.Ent.Admin.ToList().Where(i => i.Login == log.Text && i.Pass == Pass.Password.ToString()).ToList()[0];

                    Home h = new Home();
                    h.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Данные не верны!");
                    log.Text = "";
                    Pass.Password = "";
                }
            }
            catch
            {
                MessageBox.Show("Warning x0");
            }


        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Login();
        }
    }
}
