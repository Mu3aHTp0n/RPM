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
    /// Логика взаимодействия для UserRegistration.xaml
    /// </summary>
    public partial class UserRegistration : Window
    {
        public UserRegistration()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Registration_Click(object sender, RoutedEventArgs e)
        {
            List<User> users = Singletone.DB.User.Where(user => user.login == Login.Text).ToList();

            if (users.Count == 1)
            {

                MessageBox.Show("Пользователь с таким логином уже существует");
                return;
            }
            
            if (Password.Password != ConfirmPassword.Password)
            { MessageBox.Show("Пароль и проверка пароля не совпадают"); return; }
            if (Login.Text == "" || Password.Password == "" || Name.Text == "" || SurName.Text == "" || SecondName.Text == "")
            {
                MessageBox.Show("Поля не заполнены");
                return; 
            }
            
            else
            {
                User user = new User();
                People people = new People();

                user.login = Login.Text;
                user.password = Password.Password;
                user.password = ConfirmPassword.Password;
                people.Name = Name.Text;
                people.SurName = SurName.Text;
                people.SecondName = SecondName.Text;
                //people.User = user;
                Singletone.DB.User.Add(user);
                Singletone.DB.People.Add(people);
                Singletone.DB.SaveChanges();
                MessageBox.Show("Пользователь зарегистрирован");

            }
        }

    }
}
