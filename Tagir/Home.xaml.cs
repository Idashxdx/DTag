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
using Tagir.Class;

namespace Tagir
{
    /// <summary>
    /// Логика взаимодействия для Home.xaml
    /// </summary>
    public partial class Home : Window
    {
        public Home()
        {
            InitializeComponent();
            ClassFrame.Frm = Frm;
            ClassFrame.Frm.Navigate(new HomeText());
        }

        private void Tre_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.Frm.Navigate(new PageTre());
        }

        private void Det_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.Frm.Navigate(new PageDet());
        }

        private void Ras_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.Frm.Navigate(new PageRas());
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow w = new MainWindow();
            w.Show();
            this.Close();
        }
    }
}
