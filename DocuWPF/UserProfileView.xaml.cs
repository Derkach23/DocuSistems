using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
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
    public partial class UserProfileView : UserControl
    {
        public UserProfileView()
        {
            InitializeComponent();
            DataContext = this; // Устанавливаем DataContext для привязки данных

            // Пример данных профиля
            UserName = "admin";
            Email = "admin@example.com";
            Phone = "123-456-7890";
            Role = "Администратор";
        }

        public string UserName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Role { get; set; }

        private void EditButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            // Логика для редактирования профиля
            MessageBox.Show("Редактирование профиля не реализовано.");
        }
    }
}

