
using LessonsFor.DB.DBContent;
using System.Windows;
// track

namespace LessonsForWPF.Winds
{
    /// <summary>
    /// Логика взаимодействия для ChangeStudetnWindow.xaml
    /// </summary>
    public partial class ChangeStudetnWindow : Window
    {

        private Student Student;
        public ChangeStudetnWindow(Student student )
        {
            InitializeComponent();
            Student = student;
            Title = "Редактируем  студента " + Student.Name;
        }
       
    }
}
