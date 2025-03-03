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
    /// Логика взаимодействия для AuthorizationTeacherPage.xaml
    /// </summary>
    public partial class AuthorizationTeacherPage : Page
    {
        public AuthorizationTeacherPage()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click_1(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(LoginPb.Password))
            {
                MessageBox.Show("Введите пароль");

            }
            else
            {
                if (LoginPb.Password == "123")
                {
                    MessageBox.Show("Данные верны");
                    
                }
                else
                {
                    MessageBox.Show("Данные неверны");
                }
            }
        }
    }
}
