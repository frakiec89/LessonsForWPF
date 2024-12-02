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
        }

        private void btnTest_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("OK");
        }

        private void btnTest_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            
            Random random = new Random();
            btnTest.Margin = 
                new Thickness
                (
                    random.Next(500) , 
                    random.Next(500) , 
                    random.Next(500) , 
                    random.Next(500) 
                );


        }
    }
}