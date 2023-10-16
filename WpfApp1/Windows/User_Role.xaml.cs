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
    /// Логика взаимодействия для User_Role.xaml
    /// </summary>
    public partial class User_Role : Window
    {
        public User_Role()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void SaveUser_Click(object sender, RoutedEventArgs e)
        {
           User user = userMenu.SelectedItem as User;
            if (user != null)
            {
                user.Role.Clear();
                user.Role.Add(roleMenu.SelectedItem as Role);
                if (user.Role.Count != 0) 
                {
                    Singletone.DB.SaveChanges();
                }
                
            }
           
            
            
           
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            roleMenu.ItemsSource = Singletone.DB.Role.ToList();
            userMenu.ItemsSource = Singletone.DB.User.ToList();

        }

        private void Window_Closed(object sender, EventArgs e)
        {
            Singletone.DB.SaveChanges();
        }
    }
}
