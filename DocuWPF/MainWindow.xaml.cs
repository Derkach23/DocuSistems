using System.Windows;

namespace DocuWPF.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void DocumentsButton_Click(object sender, RoutedEventArgs e)
        {
            DocumentListView documentsWindow = new DocumentListView();
            documentsWindow.Show();
            this.Close(); // Закрываем главное окно, если хотите, чтобы было одно окно в одно время
        }

        private void CategoriesButton_Click(object sender, RoutedEventArgs e)
        {
            //CategoriesWindow categoriesWindow = new CategoriesWindow();
            //categoriesWindow.Show();
            // this.Close(); // Закрываем главное окно

        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            SearchWindow searchWindow = new SearchWindow();
            searchWindow.Show();
            this.Close(); // Закрываем главное окно
        }
    }
}