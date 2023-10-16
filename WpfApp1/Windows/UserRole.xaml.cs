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
    /// Логика взаимодействия для UserRole.xaml
    /// </summary>
    public partial class UserRole : Window
    {
        public UserRole()
        {
            InitializeComponent();

            List<User> users = Singletone.DB.User.ToList();
            foreach (User user in users)
                userMenu.Items.Add(user.login);

            List<Role> roles = Singletone.DB.Role.ToList();
            foreach (Role role in roles)
                roleMenu.Items.Add(role.Name);

        }

        private void saveRole_Click(object sender, RoutedEventArgs e)
        {
            

            Singletone.DB.SaveChanges();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            _ = new Student_Group();
            Close();
        }
    }
}
