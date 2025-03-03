using System.Windows;
using TestWork.View;

namespace TestWork
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TeacherBtn_Click(object sender, RoutedEventArgs e)
        {
            AuthorizationTeacherWindow authorizationTeacherWindow = new AuthorizationTeacherWindow();
            if (authorizationTeacherWindow.ShowDialog() == true)
            {
                MainFrame.Navigate(new View.PageTeacher());
            }
            else
            {
                Close();
            }
        }

        private void StudentBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new View.PageTeacher());
        }
    }
}
