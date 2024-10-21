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
    public partial class DocumentsView : UserControl
    {
        public DocumentsView()
        {
            InitializeComponent();
            LoadDocuments();
        }

        private void LoadDocuments()
        {
            // Пример загрузки документов
            DocumentsListBox.Items.Add("Документ A");
            DocumentsListBox.Items.Add("Документ B");
            DocumentsListBox.Items.Add("Документ C");
        }
    }
}
