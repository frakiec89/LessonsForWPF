
using LessonsFor.DB.DBContent;
using System.Windows;
using System.Windows.Controls;
// track

namespace LessonsForWPF.Winds
{
    /// <summary>
    /// Логика взаимодействия для StudentsWindow.xaml
    /// </summary>
    public partial class StudentsWindow : Window
    {
        public StudentsWindow()
        {
            InitializeComponent();

            Loaded += StudentsWindow_Loaded;
            Closing += StudentsWindow_Closing;
            
        }
        
        private void StudentsWindow_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                LessonsFor.DB.DBContent.MyContentDBContext dBContext = new LessonsFor.DB.DBContent.MyContentDBContext();


                dataGridStudents.ItemsSource = dBContext.Students.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void StudentsWindow_Closing(object? sender, System.ComponentModel.CancelEventArgs e)
        {
            Winds.MenuWindows windows = new Winds.MenuWindows();
            windows.Show();
        }


        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;

            if(button != null)
            {
                var student = button.DataContext as Student;
                if(student != null)
                {
                    var dialog = MessageBox.
                        Show($"Вы хотите удалить студента {student.Name} {student.FirstName}\n" +
                        $"Вы Уверены?"  , "Внимание" , MessageBoxButton.YesNo , MessageBoxImage.Warning);


                    if(dialog == MessageBoxResult.Yes)
                    {
                        try
                        {
                            using LessonsFor.DB.DBContent.MyContentDBContext dBContext = new LessonsFor.DB.DBContent.MyContentDBContext();
                            dBContext.Students.Remove(student);
                            dBContext.SaveChanges();
                            dataGridStudents.ItemsSource = dBContext.Students.ToList();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
        }

        private void btnChange_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
