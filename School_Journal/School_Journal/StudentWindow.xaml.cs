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

namespace School_Journal
{
    /// <summary>
    /// Логика взаимодействия для StudentWindow.xaml
    /// </summary>
    public partial class StudentWindow : Window
    {
        private List<Student> students = new List<Student>();

        public StudentWindow()
        {
            InitializeComponent();
            students.Add(new Student ("Иванов Иван Иванович", 16, 4.5 ));
            students.Add(new Student ("Максимов Илья Владимирович", 16, 3.2 ));
            students.Add(new Student ("Морозов Максим Дмитриевич", 19, 2.8));
            students.Add(new Student ("Морозов Андрей Дмитриевич", 14, 4.8));

            lvStudentsListView.ItemsSource = students;
            
        }
        private void AddStudent_Click(object sender, RoutedEventArgs e)
        {
            AddStudentDialog addStudentDialog = new AddStudentDialog();
            addStudentDialog.ShowDialog();
            
        }

        private void ShowAll_Click(object sender, RoutedEventArgs e)
        {
            lvStudentsListView.ItemsSource = students;
            
        }

        private void ShowFailing_Click(object sender, RoutedEventArgs e)
        {
            List<Student> failingStudents = new List<Student>();
            foreach (var student in students)
            {
                if (student.AverageGrade < 3.0)
                {
                    failingStudents.Add(student);
                }
            }
            lvStudentsListView.ItemsSource = failingStudents;
            
        }

        private void RefreshStudentList()
        {
            lvStudentsListView.ItemsSource = null;
            lvStudentsListView.ItemsSource = students;
        }
    }

    
}
