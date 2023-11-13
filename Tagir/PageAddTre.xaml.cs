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
    /// Логика взаимодействия для PageAddTre.xaml
    /// </summary>
    public partial class PageAddTre : Page
    {
        Trainers trainer = new Trainers();
        public PageAddTre()
        {
            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            trainer.FullName = TbxF.Text;
            trainer.Phone = TbxP.Text;
            trainer.Email = TbxEm.Text;
            trainer.Experience = TbxE.Text;
            ClassConnect.Ent.Trainers.Add(trainer);
            ClassConnect.Ent.SaveChanges();
            MessageBox.Show("Тренер добавлен!");
            TbxF.Text = "";
            TbxEm.Text = "";
            TbxE.Text = "";
            TbxP.Text = "";
            ClassFrame.Frm.Navigate(new PageTre());
        }
    }
}
