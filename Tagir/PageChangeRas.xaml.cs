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
    /// Логика взаимодействия для PageChangeRas.xaml
    /// </summary>
    public partial class PageChangeRas : Page
    {
        List<Group> group = new List<Group>();
   
        List<Trainers> tr = new List<Trainers>();
        List<Location> loc = new List<Location>();
        List<DayOfTheWeek> day = new List<DayOfTheWeek>();
        List<ClassTime> time = new List<ClassTime>();
     
        Schedule ras = new Schedule();
      
   
        public PageChangeRas()
        {

      
            InitializeComponent();
            ClassConnect.Ent = new tagirEntities1();
            group = ClassConnect.Ent.Group.ToList();
            tr = ClassConnect.Ent.Trainers.ToList();
            loc = ClassConnect.Ent.Location.ToList();
            day = ClassConnect.Ent.DayOfTheWeek.ToList();
            time = ClassConnect.Ent.ClassTime.ToList();
            loc = ClassConnect.Ent.Location.ToList();
            CmbG.ItemsSource = group;
            CmbM.ItemsSource = loc;
            CmbT.ItemsSource = tr;
            CmbD.ItemsSource = day;
            CmbS.ItemsSource = time;
            CmbE.ItemsSource = time;
           

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
                ras.ID_DayOfTheWeek = CmbD.SelectedIndex +1;
                ras.ID_ClassTime = CmbS.SelectedIndex +1;
                ras.ID_Trainer = CmbT.SelectedIndex +1;
                ras.ID_Location = CmbM.SelectedIndex +1;
                ras.ID_Group = CmbG.SelectedIndex +1;
            ClassConnect.Ent.Schedule.Add(ras);
            ClassConnect.Ent.SaveChanges();
            MessageBox.Show("Сохранено!");
                ClassFrame.Frm.Navigate(new PageRas());
           
        }
    }
}
