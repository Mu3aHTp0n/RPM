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

            List<People> peoples = Singletone.DB.People.ToList();
            string fullName = "";
            foreach (People people in peoples)
                fullName += people.SecondName + " " + people.Name + " " + people.SurName;
        }

        private void addStudent_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            _ = new Student_Group();
            Close();
        }
    }
}
