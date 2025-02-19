using System.Windows;
// track

namespace LessonsForWPF.Winds
{
    /// <summary>
    /// Логика взаимодействия для MenuWindows.xaml
    /// </summary>
    public partial class MenuWindows : Window
    {
        public MenuWindows()
        {
            InitializeComponent();
            btnBack.Click += BtnBack_Click;
            btnEditUser.Click += BtnEditUser_Click;
            btnAddStudent.Click += BtnAddStudent_Click;
        }

        private void BtnAddStudent_Click(object sender, RoutedEventArgs e)
        {
           Winds.AddStudentWindow addStudentWindow = new Winds.AddStudentWindow();
            addStudentWindow.Show();
            Close();
        }

        private void BtnEditUser_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Пока не  готово"); // заглушка 
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }
    }
}
