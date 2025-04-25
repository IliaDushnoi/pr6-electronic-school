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
    /// Логика взаимодействия для EditDataWindow.xaml
    /// </summary>
    public partial class EditDataWindow : Window
    {
        public EditDataWindow()
        {
            InitializeComponent();
            cmbDolzhnost.ItemsSource = doljnost;
        }
        List<string> doljnost = new List<string>() { "Массажист", "Консультант", "Администратор" };
        private void btnSaveEditData_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Изменения сохранены");
            this.Close();
        }

        private void btnCloseEditData_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
