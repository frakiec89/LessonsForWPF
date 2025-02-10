// track
using System.Windows;

namespace LessonsForWPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static List<User> Users {  get; set; } = new List<User>();
    }

    public class User
    {
        public string Login { get; set; }
        public string Password { get; set; }
    }

}
