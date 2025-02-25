
using LessonsFor.DB.DBContent;
using System.Windows;
// track

namespace LessonsForWPF.Winds
{
    /// <summary>
    /// Логика взаимодействия для ChangeStudetnWindow.xaml
    /// </summary>
    public partial class ChangeStudetnWindow : Window
    {

        public bool IsTrueUpdate { get; set; }

        private Student Student;

        public ChangeStudetnWindow(Student student )
        {
            InitializeComponent();
            Student = student;
            Title = "Редактируем  студента " + Student.Name;

            Loaded += ChangeStudetnWindow_Loaded;
            btnUpdateStydent.Click += BtnUpdateStydent_Click;
        }

        private void BtnUpdateStydent_Click(object sender, RoutedEventArgs e)
        {
            Student.FirstName = tbFerstName.Text;
            Student.Name = tbName.Text;
            Student.GroupName = tbGruipName.Text;


            try
            {
                using LessonsFor.DB.DBContent.MyContentDBContext dBContext = new LessonsFor.DB.DBContent.MyContentDBContext();
                dBContext.Students.Update( Student );
                dBContext.SaveChanges();
                IsTrueUpdate = true;
                MessageBox.Show("Успешно!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void ChangeStudetnWindow_Loaded(object sender, RoutedEventArgs e)
        {

            tbFerstName.Text = Student.FirstName;
            tbName.Text = Student.Name;
            tbGruipName.Text = Student.GroupName;

        }
    }
}
