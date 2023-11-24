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

            //// Получение данных из БД
            //List<AcademicYear> years = Singletone.DB.AcademicYear.ToList();
            //// Источник данных для ComboBox
            //academYear.ItemsSource = years;
        }

        private void SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Group choosenGroup = groupMenu.SelectedItem as Group;
            studentsTable.ItemsSource = choosenGroup.Student;
        }
    }
}
