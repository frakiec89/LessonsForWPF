using System.Windows;


// track

namespace LessonsForWPF
{
    /// <summary>
    /// Логика взаимодействия для WindowsAddUser.xaml
    /// </summary>
    public partial class WindowsAddUser : Window
    {
        public WindowsAddUser()
        {
            InitializeComponent();
            btnAddUser.Click += BtnAddUser_Click;
        }

        private void BtnAddUser_Click(object sender, RoutedEventArgs e)
        {
           if (string.IsNullOrWhiteSpace(tb_Login.Text) == true)
           {
                MessageBox.Show("Введите логин");
                return;
           }

            if (tb_Password.Text ==null ||  tb_Password.Text.Length <4)
            {
                MessageBox.Show("Пароль меньше 4 символов!");
                return;
            }

            if (tb_Password.Text != tb_Password2.Text)
            {
                MessageBox.Show("Парали  не совпадают");
                return;
            }


            User user = new User();
            user.Login = tb_Login.Text;
            user.Password = tb_Password2.Text;

            App.Users.Add(user);

            MessageBox.Show("Успешно!");

            MainWindow window = new MainWindow();   
            window.Show();
            this.Close();

            // 1 проверка логина
            // хеширование паролй
            // верификации  пользвателей  
            // и тд 

        }
    }
}
