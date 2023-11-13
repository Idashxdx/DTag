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
    /// Логика взаимодействия для PageAddDet.xaml
    /// </summary>
    public partial class PageAddDet : Page
    {

        List<Group> group = new List<Group>();

        List<GenderKids> gen = new List<GenderKids>();
        Kids kids = new Kids();
        public PageAddDet()
        {
            InitializeComponent();
            group = ClassConnect.Ent.Group.ToList();
            Cmb1.ItemsSource = group;
            gen = ClassConnect.Ent.GenderKids.ToList();
            Cmb2.ItemsSource = gen;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            kids.FullName = TbxF.Text;
            kids.DateOfBirth = Convert.ToDateTime(TbxD.Text);
            kids.Parents = TbxP.Text;
            kids.ID_Gerder = Cmb2.SelectedIndex + 1;
            kids.ID_Group = Cmb1.SelectedIndex + 1;
            ClassConnect.Ent.Kids.Add(kids);
            ClassConnect.Ent.SaveChanges();
            MessageBox.Show("Ребенок добавлен!");
            TbxF.Text = "";
            TbxD.Text = "";
            TbxP.Text = "";
            ClassFrame.Frm.Navigate(new PageDet());
        }
    }
}
