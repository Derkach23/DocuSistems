using System.Windows;

namespace DocuWPF.Views
{
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
            LoginBox.Focus(); // Устанавливаем фокус на поле логина
        }

        private void LoginBox_GotFocus(object sender, RoutedEventArgs e)
        {
            LoginPlaceholder.Visibility = Visibility.Collapsed; // Скрываем плейсхолдер
        }

        private void LoginBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(LoginBox.Text))
            {
                LoginPlaceholder.Visibility = Visibility.Visible; // Показываем плейсхолдер, если поле пустое
            }
        }

        private void PasswordBox_GotFocus(object sender, RoutedEventArgs e)
        {
            PasswordPlaceholder.Visibility = Visibility.Collapsed; // Скрываем плейсхолдер
        }

        private void PasswordBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PasswordBox.Password))
            {
                PasswordPlaceholder.Visibility = Visibility.Visible; // Показываем плейсхолдер, если поле пустое
            }
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string login = LoginBox.Text;
            string password = PasswordBox.Password;

            // Примитивная валидация (можно подключить реальную БД с пользователями)
            if (login == "admin" && password == "123")
            {
                // Передаем имя пользователя (в данном случае 'admin') в главное окно
                MainWindow mainWindow = new MainWindow(login);
                mainWindow.Show();
                this.Close(); // Закрываем окно авторизации
            }
            else
            {
                MessageBox.Show("Неправильный логин или пароль!");
            }
        }
    }
}