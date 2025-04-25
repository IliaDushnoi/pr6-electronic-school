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
    /// Логика взаимодействия для EditPassWindow.xaml
    /// </summary>
    public partial class EditPassWindow : Window
    {
        public EditPassWindow()
        {
            InitializeComponent();
        }

        private void btnSavePassword_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Пароль изменен!");
            this.Close();
        }

        private void btnCloseEditPasswordWindow_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
