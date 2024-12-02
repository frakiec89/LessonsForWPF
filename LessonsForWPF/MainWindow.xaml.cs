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

            btnTest2.Click += BtnTest2_Click; // += tab

            // я  мастер  тут  ничего не  будет
        }

        private void BtnTest2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Эвент  из кода ");
        }

        private void btnTest_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Эвент  из верстки ");
        }
    }
}