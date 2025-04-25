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
    /// Логика взаимодействия для AdminWindowPerson.xaml
    /// </summary>
    public partial class AdminWindowPerson : Window
    {
        public AdminWindowPerson()
        {
            InitializeComponent();
        }

        private void btnAdminWindowClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnAddPerson_Click(object sender, RoutedEventArgs e)
        {
            AddPersonWindow addPersonWindow = new AddPersonWindow();
            addPersonWindow.ShowDialog();
        }

        private void btnEditPass_Click(object sender, RoutedEventArgs e)
        {
            EditPassWindow editPassWindow = new EditPassWindow();
            editPassWindow.ShowDialog();
        }

        private void btnEditData_Click(object sender, RoutedEventArgs e)
        {
            EditDataWindow editDataWindow = new EditDataWindow();
            editDataWindow.ShowDialog();
        }

        private void btnDeletePerson_Click(object sender, RoutedEventArgs e)
        {

        }

    }
}
