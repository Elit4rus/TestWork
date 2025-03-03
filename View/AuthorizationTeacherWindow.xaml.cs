using System.Windows;

namespace TestWork.View
{
    /// <summary>
    /// Логика взаимодействия для AuthorizationTeacherWindow.xaml
    /// </summary>
    public partial class AuthorizationTeacherWindow : Window
    {
        public AuthorizationTeacherWindow()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(LoginPb.Password))
            {
                MessageBox.Show("Введите пароль");

            }
            else
            {
                if (LoginPb.Password == "123")
                {
                    DialogResult = true;
                    MessageBox.Show("Данные верны");
                    Close();
                }
                else
                {
                    MessageBox.Show("Данные неверны");
                }
            }
        }
    }
}
