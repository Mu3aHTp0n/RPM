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
            groupMenu.ItemsSource = Singletone.DB.Group.ToList();

            SetItemSourcePeoples();
        }
        void SetItemSourcePeoples ()
        {
            peoples.ItemsSource = PeopleView.ItemsSource(
                Singletone.DB.People.ToList(), Singletone.DB.Student.ToList());
        }

        class PeopleView
        {
            public bool Check { get; set; }
            public People People { get; set; }
            public PeopleView(People people, bool check = false)
            {
                this.People = people;
                this.Check = check;
            }
            public static List<PeopleView> ToList(List<People> peoples)
            {
                List<PeopleView> result = new List<PeopleView>();
                foreach (People people in peoples)
                {
                    result.Add(new PeopleView(people));
                }
                return result;
            }

            public static List<PeopleView> ItemsSource (List<People> peoples, List<Student> students)
            {
                foreach (Student student in students)
                {
                    if (peoples.Contains(student.People))
                    {
                        peoples.Remove(student.People);
                    }
                }
                return ToList(peoples);
            }
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            if (groupMenu.SelectedItem == null) return;
            foreach (var item in peoples.Items)
            {
                PeopleView peopleView = item as PeopleView;
                if (peopleView.Check == true)
                {
                    Student student = new Student();
                    student.People = peopleView.People;
                    student.Group = groupMenu.SelectedItem as Group;
                    student.Date = DateTime.Now;
                    Singletone.DB.Student.Add(student);
                }
            }
            Singletone.DB.SaveChanges();
            SetItemSourcePeoples();
        }
    }
}
