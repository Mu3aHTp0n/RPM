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
    /// Логика взаимодействия для Journal.xaml
    /// </summary>
    public partial class Journal : Window
    {
        public Journal()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            int year = DateTime.Now.Year;

            List<AcademicYear> academYears = Singletone.DB.AcademicYear.ToList();
            academYear.ItemsSource = academYears;
            foreach (AcademicYear academicYear in academYears)
            {
                if (year == academicYear.StartYear)
                {
                    academYear.SelectedItem = academicYear;
                    break;
                }
            }
        }

        private void SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Group choosenGroup = groupMenu.SelectedItem as Group;

            if (choosenGroup == null)
                return;

            studentsTable.ItemsSource = choosenGroup.Student;
        }

        private void academYear_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            groupMenu.ItemsSource = Singletone.DB.Group.ToList();
            groupMenu.SelectedItem = Singletone.DB.Group.ToList().FirstOrDefault();

            AcademicYear ac = academYear.SelectedItem as AcademicYear;

            List<Group> result = new List<Group>();

            foreach (Group group in groupMenu.ItemsSource = Singletone.DB.Group.ToList())
            {
                if (ac.StartYear >= group.Year && ac.StartYear < group.Year + 4)
                {
                    result.Add(group);
                }
            }

            groupMenu.ItemsSource = result.ToList();
        }
    }
}
