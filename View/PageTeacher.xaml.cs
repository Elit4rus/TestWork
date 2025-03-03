using System.Windows;
using System.Windows.Controls;
using TestWork.AppDate;

namespace TestWork.View
{
    /// <summary>
    /// Логика взаимодействия для PageTeacher.xaml
    /// </summary>
    public partial class PageTeacher : Page
    {
        public PageTeacher()
        {
            InitializeComponent();
            FrameHelper.secondFrame = SecondFrame;
        }

        private void AddStudent_Click(object sender, RoutedEventArgs e)
        {
            SecondFrame.Navigate(new View.PageAddGroup());

        }

        private void AddGroupBtn_Click(object sender, RoutedEventArgs e)
        {
            SecondFrame.Navigate(new View.PageAddStudent());
        }

        private void StudentMarkBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DelStudentBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void EscapeBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
