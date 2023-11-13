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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Tagir.Class;

namespace Tagir
{
    /// <summary>
    /// Логика взаимодействия для PageTre.xaml
    /// </summary>
    public partial class PageTre : Page
    {
        List<Trainers> trainer = new List<Trainers>();
        public PageTre()
        {
            InitializeComponent();
            trainer = ClassConnect.Ent.Trainers.ToList();
            LBox.ItemsSource = trainer;
            Load2();
        }
        private void Load2()
        {
            trainer = ClassConnect.Ent.Trainers.ToList();
            if (Tbx1.Text != string.Empty)
            {
                if (Tbx1.Text != "Введите для поиска")
                {

                    trainer = trainer.Where(x => x.FullName.ToLower().Contains(Tbx1.Text.ToLower())).ToList();
                    LBox.ItemsSource = trainer;
                    if (trainer.Count == 0)
                    {
                        TblNo.Visibility = Visibility.Visible;
                    }
                    else
                    {

                        TblNo.Visibility = Visibility.Hidden;
                    }
                }

            }
            else
            {
                LBox.ItemsSource = trainer;
                TblNo.Visibility = Visibility.Hidden;
            }


        }
        private void Tbx1_SelectionChanged(object sender, RoutedEventArgs e)
        {
            Load2();
        }

        private void Tbx1_GotFocus(object sender, RoutedEventArgs e)
        {
            if (Tbx1.Text == "Введите для поиска")
            {
                Tbx1.Text = string.Empty;
            }
        }

        private void Tbx1_LostFocus(object sender, RoutedEventArgs e)
        {
            if (Tbx1.Text == string.Empty)
            {
                Tbx1.Text = "Введите для поиска";
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.Frm.Navigate(new PageAddTre());
        }

        private void LBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (MessageBox.Show("Вы точно хотите удалить?", "Внимание!", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {

                ClassConnect.Ent.Trainers.Remove(LBox.SelectedItem as Trainers);
                ClassConnect.Ent.SaveChanges();
                MessageBox.Show("Данные Удалены!");
                ClassFrame.Frm.Navigate(new PageTre());
            }
        }
    }
}
