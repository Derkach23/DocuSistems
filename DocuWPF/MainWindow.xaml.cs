using System.Windows;

namespace DocuWPF.Views
{
    public partial class MainWindow : Window
    {
        public string UserName { get; set; } // Свойство для хранения имени пользователя

        public MainWindow(string userName)
        {
            InitializeComponent();
            DataContext = this;  // Привязываем данные
        }

        private void DocumentsButton_Click(object sender, RoutedEventArgs e)
        {
            // Загружаем представление документов в правую часть окна
            MainContent.Content = new DocumentsView();
        }

        private void CategoriesButton_Click(object sender, RoutedEventArgs e)
        {
            // Загружаем представление категорий в правую часть окна
            MainContent.Content = new CategoriesView();
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            // Загружаем представление поиска в правую часть окна
            MainContent.Content = new SearchView();
        }

        private void DocumentOperationsButton_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new DocumentOperationsView();
        }

        private void DocumentStatisticsButton_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new DocumentStatisticsView();
        }

        private void UserProfileButton_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new UserProfileView();
        }
    }
}