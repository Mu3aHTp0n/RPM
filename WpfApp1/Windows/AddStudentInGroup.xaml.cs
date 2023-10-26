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

namespace WpfApp1.Windows
{
    /// <summary>
    /// Логика взаимодействия для AddStudentInGroup.xaml
    /// </summary>
    public partial class AddStudentInGroup : Window
    {
        public AddStudentInGroup()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            GroupMenu.ItemsSource = Singletone.DB.People.ToList();

            Singletone.DB.People.ToList();

            people.ItemsSource = Singletone.DB.People.Local;
        }

        private void UpdateComboBox()
        {
            Group groups = groupMenu.SelectedItem as Group;
            if (groups == null) return;

            List<Student> students = Singletone.DB.Student.ToList();
            List<People> peoplesId = Singletone.DB.People.ToList();
            
            //List<Role> allroles = Singletone.DB.Role.ToList();
            //foreach (Role role in user.Role)
            //{
            //    if ()
            //}
        }
    }
}
