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

namespace Electronic_School
{
    /// <summary>
    /// Логика взаимодействия для AdminMainMenu.xaml
    /// </summary>
    public partial class AdminMainMenu : Window
    {
        public AdminMainMenu()
        {
            InitializeComponent();
        }

        private void btnShowPersonWindow_Click(object sender, RoutedEventArgs e)
        {
            AdminWindowPerson adminWindowPerson = new AdminWindowPerson();
            adminWindowPerson.ShowDialog();
        }

        private void btnShowApplications_Click(object sender, RoutedEventArgs e)
        {
            AdminApplicationsWindow adminApplicationsWindow = new AdminApplicationsWindow();
            adminApplicationsWindow.ShowDialog();
        }

        private void btnShowProgInf_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("О программе:\nРазработчик: Слабожанин Илья\nВерсия: 0.2");
        }

        private void btnCloseMainMenu_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
