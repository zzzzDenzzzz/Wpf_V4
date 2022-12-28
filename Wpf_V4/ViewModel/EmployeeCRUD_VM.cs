using Wpf_V4.Model;
using Wpf_V4.ViewModel.Notify;

namespace Wpf_V4.ViewModel
{
    internal class EmployeeCRUD_VM : NotifyClass
    {
        public EmployeeCRUD_VM(Employee employee = null)
        {
            _currentEmployee = new Employee();
            if (employee != null)
            {
                _currentEmployee.Name = employee.Name;
                _currentEmployee.Surname = employee.Surname;
                _currentEmployee.Patronymic = employee.Patronymic;
                _currentEmployee.PhoneNumber = employee.PhoneNumber;
                _currentEmployee.JobTitle = employee.JobTitle;
                _currentEmployee.Departament = employee.Departament;
                _currentEmployee.Login = employee.Login;
                _currentEmployee.Password = employee.Password;
                _currentEmployee.EMail = employee.EMail;
            }
        }

        private Employee _currentEmployee;
        public Employee CurrentEmployee
        {
            get => _currentEmployee;
            set
            {
                _currentEmployee = value;
                OnPropertyChanged();
            }
        }

        public string Name
        {
            get => _currentEmployee.Name;
            set
            {
                _currentEmployee.Name = value;
                OnPropertyChanged();
            }
        }

        public string Surname
        {
            get => _currentEmployee.Surname;
            set
            {
                _currentEmployee.Surname = value;
                OnPropertyChanged();
            }
        }

        public string Patronymic
        {
            get => _currentEmployee.Patronymic;
            set
            {
                _currentEmployee.Patronymic = value;
                OnPropertyChanged();
            }
        }

        public string PhoneNumber
        {
            get => _currentEmployee.PhoneNumber;
            set
            {
                _currentEmployee.PhoneNumber = value;
                OnPropertyChanged();
            }
        }

        public string JobTitle
        {
            get => _currentEmployee.JobTitle;
            set
            {
                _currentEmployee.JobTitle = value;
                OnPropertyChanged();
            }
        }

        public string Departament
        {
            get => _currentEmployee.Departament;
            set
            {
                _currentEmployee.Departament = value;
                OnPropertyChanged();
            }
        }

        public string Login
        {
            get => _currentEmployee.Login;
            set
            {
                _currentEmployee.Login = value;
                OnPropertyChanged();
            }
        }

        public string Password
        {
            get => _currentEmployee.Password;
            set
            {
                _currentEmployee.Password = value;
                OnPropertyChanged();
            }
        }

        public string EMail
        {
            get => _currentEmployee.EMail;
            set
            {
                _currentEmployee.EMail = value;
                OnPropertyChanged();
            }
        }

        public void SaveEmployee()
        {
            for (int i = 0; i < EmployeeDB.Context.Employees.Count; i++)
            {
                if (EmployeeDB.Context.Employees[i].Name == _currentEmployee.Name)
                {
                    EmployeeDB.Context.Employees[i].Surname = _currentEmployee.Surname;
                    EmployeeDB.Context.Employees[i].Patronymic = _currentEmployee.Patronymic;
                    EmployeeDB.Context.Employees[i].PhoneNumber = _currentEmployee.PhoneNumber;
                    EmployeeDB.Context.Employees[i].JobTitle = _currentEmployee.JobTitle;
                    EmployeeDB.Context.Employees[i].Departament = _currentEmployee.Departament;
                    EmployeeDB.Context.Employees[i].Login = _currentEmployee.Login;
                    EmployeeDB.Context.Employees[i].Password = _currentEmployee.Password;
                    EmployeeDB.Context.Employees[i].EMail = _currentEmployee.EMail;

                    return;
                }

            }
            EmployeeDB.Context.Employees.Add(_currentEmployee);
        }
    }
}
