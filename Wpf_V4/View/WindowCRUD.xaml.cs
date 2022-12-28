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
using System.Windows.Shapes;
using Wpf_V4.Model;
using Wpf_V4.ViewModel;

namespace Wpf_V4.View
{
    /// <summary>
    /// Логика взаимодействия для WindowCRUD.xaml
    /// </summary>
    public partial class WindowCRUD : Window
    {
        private EmployeeCRUD_VM _vm;

        public WindowCRUD(Employee employee = null)
        {
            InitializeComponent();
            _vm = new EmployeeCRUD_VM(employee);
            DataContext = _vm;
            Title = "Добавление";
            if (employee != null)
            {
                NameTextBox.IsReadOnly = true;
                Title = "Изменение";
            }
        }

        private void Clouse_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            _vm.SaveEmployee();
            Close();
        }
    }
}
