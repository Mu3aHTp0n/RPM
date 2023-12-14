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
            groupMenu.ItemsSource = Singletone.DB.Group.ToList();
            academYear.ItemsSource = Singletone.DB.AcademicYear.ToList();
            int y = DateTime.Now.Year;
            int m = DateTime.Now.Month;
            
            var result = new List<AcademicYear>();
            academYear.SelectedItem = (academYear.ItemsSource as List<AcademicYear>).Find(x => x.StartYear == DateTime.Now.Year && DateTime.Now.Month >= 9 || x.EndYear == DateTime.Now.Year && DateTime.Now.Month <= 8);
            if (result.Count != 0)
                academYear.SelectedItem = result[0];
        }
        private void SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Group choosenGroup = groupMenu.SelectedItem as Group;
            studentsTable.ItemsSource = choosenGroup.Student;
        }
    }
}
