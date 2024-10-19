using System;
using System.Windows;
using DocuWPF.Models;

namespace DocuWPF.Views
{
    public partial class DocumentEditor : Window
    {
        public DocumentEditor()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            Document newDocument = new Document
            {
                Title = TitleBox.Text,
                Content = ContentBox.Text,
                DateCreated = DateTime.Now,
                Category = "Категория"
            };

            // Логика сохранения документа в базу данных

            MessageBox.Show("Документ сохранен!");
            this.Close();
        }
    }
}