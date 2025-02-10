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
                MessageBox.Show("Пароль меньше 3 символов!");
                return;
            }

            if (tb_Password.Text != tb_Password2.Text)
            {
                MessageBox.Show("Парали  не совпадают");
                return;
            }

        }
    }
}
