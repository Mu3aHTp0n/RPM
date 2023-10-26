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
    /// Логика взаимодействия для SetRole.xaml
    /// </summary>
    public partial class SetRole : Window
    {
        public SetRole()
        {
            InitializeComponent();
        }
        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            userMenu.ItemsSource = Singletone.DB.User.ToList();
        }


        private void UpdateListBox()
        {
            User user = userMenu.SelectedItem as User;
            if (user == null) return;
            
            List<Role> allroles = Singletone.DB.Role.ToList();
            foreach (Role role in user.Role)
                allroles.Remove(role);
            userNoSetRole.ItemsSource = allroles;
            userSetRole.ItemsSource = user.Role.ToList();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            Singletone.DB.SaveChanges();
        }

        private void userMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateListBox();
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            if (userNoSetRole.ItemsSource == null) return;
            if (userMenu.SelectedItem == null) return;

            User user = userMenu.SelectedItem as User;
            user.Role.Add(userNoSetRole.SelectedItem as Role);
            UpdateListBox();
        }

        private void addAll_Click(object sender, RoutedEventArgs e)
        {
            if (userMenu.SelectedItem == null) return;
            User user = userMenu.SelectedItem as User;

            foreach (Role role in userNoSetRole.Items)
                user.Role.Add(role);
            UpdateListBox();
        }

        private void del_Click(object sender, RoutedEventArgs e)
        {
            if (userSetRole.ItemsSource == null) return;
            if (userMenu.SelectedItem == null) return;

            User user = userMenu.SelectedItem as User;
            user.Role.Remove(userSetRole.SelectedItem as Role);
            UpdateListBox();
        }

        private void delAll_Click(object sender, RoutedEventArgs e)
        {
            if (userMenu.SelectedItem == null) return;

            User user = userMenu.SelectedItem as User;
            user.Role.Clear();
            UpdateListBox();
        }

        private void SaveUser_Click(object sender, RoutedEventArgs e)
        {
            Singletone.DB.SaveChanges();
        }
    }
}
