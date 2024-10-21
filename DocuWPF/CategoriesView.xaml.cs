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
    public partial class CategoriesView : UserControl
    {
        public CategoriesView()
        {
            InitializeComponent();
            DataContext = this; // Устанавливаем DataContext для привязки данных

            // Пример данных для категорий
            Categories = new List<Category>
                {
                new Category { Name = "Отчеты", Description = "Документы, связанные с отчетностью." },
                new Category { Name = "Нормативы", Description = "Документы с нормативными актами." },
                new Category { Name = "Инструкции", Description = "Документы, содержащие инструкции." }
            };
        }
        public List<Category> Categories { get; set; }
    }

    public class Category
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
    

