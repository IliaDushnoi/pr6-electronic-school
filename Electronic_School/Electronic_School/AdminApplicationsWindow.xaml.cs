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
    /// Логика взаимодействия для AdminApplicationsWindow.xaml
    /// </summary>
    public partial class AdminApplicationsWindow : Window
    {
        public AdminApplicationsWindow()
        {
            InitializeComponent();
            cmbStatus.ItemsSource = status;
        }
        List<string> status = new List<string>() {"Выполнен", "Невыполнен", "Выполняется" };

        private void btnEditStatus_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
