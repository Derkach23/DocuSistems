using LiveCharts;
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
    public partial class DocumentStatisticsView : UserControl
    {
        public DocumentStatisticsView()
        {
            InitializeComponent();
            DataContext = this; // Устанавливаем DataContext для привязки данных

            // Пример данных для диаграммы
            DocumentSeriesValues = new ChartValues<int> { 20 };
            ReportSeriesValues = new ChartValues<int> { 15 };
            InstructionSeriesValues = new ChartValues<int> { 10 };
        }

        public ChartValues<int> DocumentSeriesValues { get; set; }
        public ChartValues<int> ReportSeriesValues { get; set; }
        public ChartValues<int> InstructionSeriesValues { get; set; }
    }
}
 