using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Wpf_V4.Model;
using Wpf_V4.ViewModel.Notify;

namespace Wpf_V4.ViewModel
{
    internal class EmployeeVM : NotifyClass
    {
        public EmployeeVM()
        {
            Employees = EmployeeDB.Context.Employees.ToList();
        }
        public List<Employee> Employees { get; set; }
        public List<Employee> SelectedEmployees { get; set; }

        private string _searchText;
        public string SearchText
        {
            get { return _searchText; }
            set
            {
                _searchText = value;
                OnPropertyChanged();
            }
        }

        public void UpdateListEmployee()
        {
            Employees = EmployeeDB.Context.Employees.Where(x => _searchText == string.Empty || _searchText == null
                            || x.Name.ToLower().Contains(_searchText.ToLower())
                            || x.Surname.ToLower().Contains(_searchText.ToLower())
                            || x.Patronymic.ToLower().Contains(_searchText.ToLower())
                            || x.Login.ToLower().Contains(_searchText.ToLower())
                            || x.PhoneNumber.ToLower().Contains(_searchText.ToLower())).ToList();
            OnPropertyChanged(nameof(Employees));
        }

        public void DeleteEmployee()
        {
            foreach (var r in SelectedEmployees)
            {
                EmployeeDB.Context.Employees.Remove(r);
            }
            Employees = EmployeeDB.Context.Employees.ToList();
            SelectedEmployees.Clear();
            OnPropertyChanged(nameof(Employees));
        }

        public void ModifyEmployee()
        {
            Employees = EmployeeDB.Context.Employees.ToList();
            OnPropertyChanged(nameof(Employees));
        }
    }
}
