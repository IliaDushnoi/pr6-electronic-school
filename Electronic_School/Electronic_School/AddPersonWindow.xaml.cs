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
    /// Логика взаимодействия для AddPersonWindow.xaml
    /// </summary>
    public partial class AddPersonWindow : Window
    {
        public AddPersonWindow()
        {
            InitializeComponent();
            cmbDolzhnost.ItemsSource = doljnost;
        }

        List<string> doljnost = new List<string>() { "Массажист", "Консультант","Администратор" };

        private void btnSavePerson_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Сотрудник успешно добавлен!");
            this.Close();
        }

        private void btnCloseAddPersonWindow_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        
    }
}
