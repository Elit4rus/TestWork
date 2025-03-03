using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
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
        }

        private void AddStudent_Click(object sender, RoutedEventArgs e)
        {
           // FrameHelper.mainFrame(new View.PageAddStudent()); // спросите у Монастыревой, как сделать ссылку на страницу в странице. Просто мы хз
        }

        private void AddGroupBtn_Click(object sender, RoutedEventArgs e)
        {
           // FrameHelper.mainFrame(new View.PageAddGroup()); // спросите у Монастыревой, как сделать ссылку на страницу в странице. Просто мы хз
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
