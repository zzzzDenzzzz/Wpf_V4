using System.Linq;
using System.Windows;
using Wpf_V4.Model;
using Wpf_V4.View;
using Wpf_V4.ViewModel;

namespace Wpf_V4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private EmployeeVM _vm;
        public MainWindow()
        {
            InitializeComponent();
            _vm = new EmployeeVM();
            DataContext = _vm;
        }

        private void DeleteEmployee_Click(object sender, RoutedEventArgs e)
        {
            _vm.SelectedEmployees = EmployeesLV.SelectedItems.Cast<Employee>().ToList();
            _vm.DeleteEmployee();

        }

        private void ModifyEmployee_Click(object sender, RoutedEventArgs e)
        {
            _vm.SelectedEmployees = EmployeesLV.SelectedItems.Cast<Employee>().ToList();
            Employee movie = _vm.SelectedEmployees.FirstOrDefault();
            if (movie != null)
            {
                WindowCRUD windowCRUD = new WindowCRUD(movie);
                windowCRUD.ShowDialog();
                _vm.ModifyEmployee();
            }
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            WindowCRUD windowCRUD = new WindowCRUD();
            windowCRUD.ShowDialog();
            _vm.ModifyEmployee();
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            _vm.UpdateListEmployee();
        }
    }
}
