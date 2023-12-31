﻿using System;
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
            foreach (People people in peoples)
                studentsMenu.Items.Add(people.SecondName + " " + people.Name + " " + people.SurName);

            List<Group> groups = Singletone.DB.Group.ToList();
            foreach (Group group in groups)
                groupMenu.Items.Add(group.Name);
        }

        private void addStudent_Click(object sender, RoutedEventArgs e)
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
