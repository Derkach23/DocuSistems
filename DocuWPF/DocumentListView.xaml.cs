using System.Windows;

namespace DocuWPF.Views
{
    public partial class DocumentListView : Window
    {
        public DocumentListView()
        {
            InitializeComponent();
        }
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close(); // Закрываем текущее окно
        }
    }
}