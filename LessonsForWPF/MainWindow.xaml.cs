// track
using System.Windows;


namespace LessonsForWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            btnAhty.Click += BtnAhty_Click;
            btnAdd.Click += BtnAdd_Click;
        }

        private void BtnAhty_Click(object sender, RoutedEventArgs e)
        {
            string login = tb_Login.Text;
            string password = tb_Password.Text;

            if (login == "admin" && password == "123")
            {
                MessageBox.Show("Ура");
            }
            else
            {
                MessageBox.Show("Не  верный логин  и пароль");
            }
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("В разработке ");
        }
    }
}