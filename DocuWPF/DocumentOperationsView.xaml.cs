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
    public partial class DocumentOperationsView : UserControl
    {
        public DocumentOperationsView()
        {
            InitializeComponent();
            LoadDocuments(); // Загрузка документов в ListBox при инициализации
        }
        private void CreateDocument_Click(object sender, RoutedEventArgs e)
        {
            // Логика создания документа
            MessageBox.Show("Создание нового документа");
        }

        private void EditDocument_Click(object sender, RoutedEventArgs e)
        {
            // Логика редактирования документа
            if (DocumentsListBox.SelectedItem != null)
            {
                MessageBox.Show("Редактирование документа: " + DocumentsListBox.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("Выберите документ для редактирования");
            }
        }

        private void DeleteDocument_Click(object sender, RoutedEventArgs e)
        {
            // Логика удаления документа
            if (DocumentsListBox.SelectedItem != null)
            {
                MessageBox.Show("Документ удалён: " + DocumentsListBox.SelectedItem.ToString());
                DocumentsListBox.Items.Remove(DocumentsListBox.SelectedItem);
            }
            else
            {
                MessageBox.Show("Выберите документ для удаления");
            }
        }

        private void LoadDocuments()
        {
            // Пример загрузки документов в ListBox
            DocumentsListBox.Items.Add("Документ 1");
            DocumentsListBox.Items.Add("Документ 2");
            DocumentsListBox.Items.Add("Документ 3");
        }
    }
}
