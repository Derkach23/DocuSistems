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

namespace DocuWPF
{
    public partial class SearchView : UserControl
    {
        public SearchView()
        {
            InitializeComponent();
        }
        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            // Получаем данные для поиска
            string keyword = KeywordBox.Text;
            DateTime? selectedDate = DatePicker.SelectedDate;
            ComboBoxItem selectedTypeItem = TypeComboBox.SelectedItem as ComboBoxItem;
            string selectedType = selectedTypeItem != null ? selectedTypeItem.Content.ToString() : null;

            // Примитивная логика поиска (можно заменить на реальную логику с подключением к БД)
            ResultsListBox.Items.Clear();

            if (!string.IsNullOrEmpty(keyword))
            {
                ResultsListBox.Items.Add($"Документ с ключевым словом '{keyword}' найден.");
            }

            if (selectedDate.HasValue)
            {
                ResultsListBox.Items.Add($"Документ с датой {selectedDate.Value.ToShortDateString()} найден.");
            }

            if (!string.IsNullOrEmpty(selectedType))
            {
                ResultsListBox.Items.Add($"Документ типа '{selectedType}' найден.");
            }

            if (ResultsListBox.Items.Count == 0)
            {
                ResultsListBox.Items.Add("Нет результатов по вашему запросу.");
            }
        }
    }
}