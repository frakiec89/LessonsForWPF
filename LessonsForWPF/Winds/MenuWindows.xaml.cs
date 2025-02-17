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

        }

        private void BtnEditUser_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }
    }
}
