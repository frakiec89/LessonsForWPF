using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using LessonsFor.DB.DBContent;
// track

namespace LessonsForWPF.Winds
{
    /// <summary>
    /// Логика взаимодействия для AddStudentWindow.xaml
    /// </summary>
    public partial class AddStudentWindow : Window
    {
        public AddStudentWindow()
        {
            InitializeComponent();
            btnBackMenu.Click += BtnBackMenu_Click;
            btnAddStydent.Click += BtnAddStydent_Click;
        }

        private void BtnAddStydent_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                StudentService studentService = new StudentService();

                studentService.Add(tbName.Text, tbFerstName.Text, tbGruipName.Text);
                MessageBox.Show("Ура!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnBackMenu_Click(object sender, RoutedEventArgs e)
        {
             Winds.MenuWindows menuWindows = new Winds.MenuWindows();
              menuWindows.Show();
               Close();
        }
    }
}
