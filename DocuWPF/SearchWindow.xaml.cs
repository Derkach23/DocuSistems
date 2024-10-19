using System;
using System.Windows;
using System.Windows.Controls;

namespace DocuWPF.Views
{
    public partial class SearchWindow : Window
    {
        public SearchWindow()
        {
            InitializeComponent();
        }
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close(); // Закрываем текущее окно
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            string keyword = KeywordBox.Text;
            DateTime? selectedDate = DatePicker.SelectedDate;
            string selectedType = (TypeComboBox.SelectedItem as ComboBoxItem)?.Content.ToString();

            // Логика поиска документа
            MessageBox.Show($"Поиск по ключевому слову: {keyword}, Дата: {selectedDate}, Тип: {selectedType}");
        }
    }
}