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
    /// Логика взаимодействия для PageRas.xaml
    /// </summary>
    public partial class PageRas : Page
    {
        List<Schedule> ras1 = new List<Schedule>();
        List<Schedule> ras2 = new List<Schedule>();
        List<Schedule> ras3 = new List<Schedule>();
        List<Schedule> ras4 = new List<Schedule>();
        List<Schedule> ras5 = new List<Schedule>();
        List<Schedule> ras6 = new List<Schedule>();
        List<Schedule> ras7 = new List<Schedule>();
        List<Group> group = new List<Group>();
        public PageRas()
        {
            InitializeComponent();
            ras1 = ClassConnect.Ent.Schedule.Where(i => i.ID_DayOfTheWeek == 1).ToList();
            ras2 = ClassConnect.Ent.Schedule.Where(i => i.ID_DayOfTheWeek == 2).ToList();
            ras3 = ClassConnect.Ent.Schedule.Where(i => i.ID_DayOfTheWeek == 3).ToList();
            ras4 = ClassConnect.Ent.Schedule.Where(i => i.ID_DayOfTheWeek == 4).ToList();
            ras5 = ClassConnect.Ent.Schedule.Where(i => i.ID_DayOfTheWeek == 5).ToList();
            ras6 = ClassConnect.Ent.Schedule.Where(i => i.ID_DayOfTheWeek == 6).ToList();
            ras7 = ClassConnect.Ent.Schedule.Where(i => i.ID_DayOfTheWeek == 7).ToList();
            LBox1.ItemsSource = ras1;
            LBox2.ItemsSource = ras2;
            LBox3.ItemsSource = ras3;
            LBox4.ItemsSource = ras4;
            LBox5.ItemsSource = ras5;
            LBox6.ItemsSource = ras6;
            LBox7.ItemsSource = ras7;
            group = ClassConnect.Ent.Group.ToList();
            group.Insert(0, new Group { Name = "Не выбрано", ID_Type = 1 });

            Cmb1.ItemsSource = group;
            Cmb1.SelectedIndex = 0;

            Load();
        }
        private void Load()//фильтрация
        {
            ras1 = ClassConnect.Ent.Schedule.Where(i => i.ID_DayOfTheWeek == 1).ToList();
            ras2 = ClassConnect.Ent.Schedule.Where(i => i.ID_DayOfTheWeek == 2).ToList();
            ras3 = ClassConnect.Ent.Schedule.Where(i => i.ID_DayOfTheWeek == 3).ToList();
            ras4 = ClassConnect.Ent.Schedule.Where(i => i.ID_DayOfTheWeek == 4).ToList();
            ras5 = ClassConnect.Ent.Schedule.Where(i => i.ID_DayOfTheWeek == 5).ToList();
            ras6 = ClassConnect.Ent.Schedule.Where(i => i.ID_DayOfTheWeek == 6).ToList();
            ras7 = ClassConnect.Ent.Schedule.Where(i => i.ID_DayOfTheWeek == 7).ToList();
            if (Cmb1.SelectedIndex != 0)
            {
                ras1 = ras1.Where(i => i.ID_Group == Cmb1.SelectedIndex).ToList();
                ras2 = ras2.Where(i => i.ID_Group == Cmb1.SelectedIndex).ToList();
                ras3 = ras3.Where(i => i.ID_Group == Cmb1.SelectedIndex).ToList();
                ras4 = ras4.Where(i => i.ID_Group == Cmb1.SelectedIndex).ToList();
                ras5 = ras5.Where(i => i.ID_Group == Cmb1.SelectedIndex).ToList();
                ras6 = ras6.Where(i => i.ID_Group == Cmb1.SelectedIndex).ToList();
                ras7 = ras7.Where(i => i.ID_Group == Cmb1.SelectedIndex).ToList();

            }
            LBox1.ItemsSource = ras1;
            LBox2.ItemsSource = ras2;
            LBox3.ItemsSource = ras3;
            LBox4.ItemsSource = ras4;
            LBox5.ItemsSource = ras5;
            LBox6.ItemsSource = ras6;
            LBox7.ItemsSource = ras7;

        }

        private void Cmb1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Load();
        }

        private void LBox1_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (MessageBox.Show("Вы точно хотите удалить?", "Внимание!", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {

                ClassConnect.Ent.Schedule.Remove(LBox1.SelectedItem as Schedule);
                ClassConnect.Ent.SaveChanges();
                MessageBox.Show("Данные Удалены!");
                ClassFrame.Frm.Navigate(new PageRas());
            }
        }

        private void LBox7_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (MessageBox.Show("Вы точно хотите удалить?", "Внимание!", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {

                ClassConnect.Ent.Schedule.Remove(LBox7.SelectedItem as Schedule);
                ClassConnect.Ent.SaveChanges();
                MessageBox.Show("Данные Удалены!");
                ClassFrame.Frm.Navigate(new PageRas());
            }
        }

        private void LBox6_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (MessageBox.Show("Вы точно хотите удалить?", "Внимание!", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {

                ClassConnect.Ent.Schedule.Remove(LBox6.SelectedItem as Schedule);
                ClassConnect.Ent.SaveChanges();
                MessageBox.Show("Данные Удалены!");
                ClassFrame.Frm.Navigate(new PageRas());
            }
        }

        private void LBox5_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (MessageBox.Show("Вы точно хотите удалить?", "Внимание!", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {

                ClassConnect.Ent.Schedule.Remove(LBox5.SelectedItem as Schedule);
                ClassConnect.Ent.SaveChanges();
                MessageBox.Show("Данные Удалены!");
                ClassFrame.Frm.Navigate(new PageRas());
            }
        }

        private void LBox4_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (MessageBox.Show("Вы точно хотите удалить?", "Внимание!", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {

                ClassConnect.Ent.Schedule.Remove(LBox4.SelectedItem as Schedule);
                ClassConnect.Ent.SaveChanges();
                MessageBox.Show("Данные Удалены!");
                ClassFrame.Frm.Navigate(new PageRas());
            }
        }

        private void LBox3_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (MessageBox.Show("Вы точно хотите удалить?", "Внимание!", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {

                ClassConnect.Ent.Schedule.Remove(LBox3.SelectedItem as Schedule);
                ClassConnect.Ent.SaveChanges();
                MessageBox.Show("Данные Удалены!");
                ClassFrame.Frm.Navigate(new PageRas());
            }
        }

        private void LBox2_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (MessageBox.Show("Вы точно хотите удалить?", "Внимание!", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {

                ClassConnect.Ent.Schedule.Remove(LBox2.SelectedItem as Schedule);
                ClassConnect.Ent.SaveChanges();
                MessageBox.Show("Данные Удалены!");
                ClassFrame.Frm.Navigate(new PageRas());
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.Frm.Navigate(new PageChangeRas());
        }
    }
}
