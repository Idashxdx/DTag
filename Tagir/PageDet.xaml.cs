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
    /// Логика взаимодействия для PageDet.xaml
    /// </summary>
    public partial class PageDet : Page
    {
        List<Kids> kids = new List<Kids>();
        List<Group> group = new List<Group>();
       
        public PageDet()
        {
            InitializeComponent();
            kids = ClassConnect.Ent.Kids.ToList();
            LBox.ItemsSource = kids;
            group = ClassConnect.Ent.Group.ToList();
            group.Insert(0, new Group { Name = "Не выбрано", ID_Type =1});

           

            Cmb1.ItemsSource = group;
            Cmb1.SelectedIndex = 0;

            Load();
            Load2();
        }

        private void Load()//фильтрация
        {
            kids = ClassConnect.Ent.Kids.ToList();

            if (Cmb1.SelectedIndex != 0)
            {
                kids = kids.Where(i => i.ID_Group == Cmb1.SelectedIndex).ToList();

            }
            LBox.ItemsSource = kids;
        }

        private void Cmb1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Load();
        }
        private void Load2()
        {
            kids = ClassConnect.Ent.Kids.ToList();
            if (Tbx1.Text != string.Empty)
            {
                if (Tbx1.Text != "Введите для поиска")
                {
                    Load();
                    kids = kids.Where(x => x.FullName.ToLower().Contains(Tbx1.Text.ToLower())).ToList();
                    LBox.ItemsSource = kids;
                    if (kids.Count == 0)
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
                LBox.ItemsSource = kids;
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
            ClassFrame.Frm.Navigate(new PageAddDet());
        }

        private void LBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
             
            if (MessageBox.Show("Вы точно хотите удалить?", "Внимание!", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {

                ClassConnect.Ent.Kids.Remove(LBox.SelectedItem as Kids);
                ClassConnect.Ent.SaveChanges();
                MessageBox.Show("Данные Удалены!");
                ClassFrame.Frm.Navigate(new PageDet());
            }
        }
    }
}
