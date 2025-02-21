
using System.Windows;
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
    }
}
