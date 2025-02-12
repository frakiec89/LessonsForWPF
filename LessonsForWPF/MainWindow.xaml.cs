// track
using LessonsForWPF.DB;
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
            // я  мастер  тут  ничего не  будет

            DB.MyMyContext context = new DB.MyMyContext();


            User user = new User();
            user.Name = "TestName";
            user.Email = "TestEmail";
            user.Password = "TestPassword";

            context.Users.Add(user);

            context.SaveChanges();


        }
    }
}