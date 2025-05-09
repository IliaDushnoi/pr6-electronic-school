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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Electronic_School
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string AdminLogin = "admin";
        string AdminPassword = "123";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            if (tbLogin.Text == AdminLogin && tbPassword.Text == AdminPassword)
            {
                AdminMainMenu adminMainMenu = new AdminMainMenu();
                this.Close();
                adminMainMenu.ShowDialog();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль!\nПопробуйте еще раз.");
            }
        }

        private void btnCloseoginWindow_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
