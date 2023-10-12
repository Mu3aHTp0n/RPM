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
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Student_Group : Window
    {
        public Student_Group()
        {
            InitializeComponent();
            
        }

        private void addStudent_Click(object sender, RoutedEventArgs e)
        {
           //List<People> people = Singletone.DB.People.ToList();
           //List <string> student_group = new List<string>();
           // foreach (Student student in people.Student)
           // {
           //     student_group.Add(people.Name);
           // }

        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            //ZavOtdeleniya zavOtdeleniya = new ZavOtdeleniya();
            //Hide();
            //zavOtdeleniya.ShowDialog();
            //Show();
            Student_Group student_Group = new Student_Group();
            Close();
        }
    }
}
