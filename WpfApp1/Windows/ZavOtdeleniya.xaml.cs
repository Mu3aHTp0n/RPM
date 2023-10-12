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
    /// Логика взаимодействия для ZavOtdeleniya.xaml
    /// </summary>
    public partial class ZavOtdeleniya : Window
    {
        public ZavOtdeleniya()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Singletone.DB.Group.ToList();
            Singletone.DB.Student.ToList();

            group.ItemsSource = Singletone.DB.Group.Local;
            student.ItemsSource = Singletone.DB.Student.Local;
            //student_fio.ItemsSource = Singletone.DB.People.ToList();
            student_group.ItemsSource = Singletone.DB.Group.ToList();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            Singletone.DB.SaveChanges();
        }

    }

    public class StudentView
    {

    }
}
