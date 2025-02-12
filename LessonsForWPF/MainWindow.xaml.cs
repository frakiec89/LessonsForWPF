// track
using LessonsFor.DB;
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

            try
            {
                using MyDbContext myDbContext = new MyDbContext();

                if (myDbContext.Users.Any(x => x.Password == tb_Password.Text && x.Login == tb_Login.Text))
                {
                    MessageBox.Show("Ура");
                }
                else
                {
                    MessageBox.Show("Не  верный логин  и пароль");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

           
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
          
            WindowsAddUser w = new WindowsAddUser();
            w.Show();
            this.Close();
        }
    }
}