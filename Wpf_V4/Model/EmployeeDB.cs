using System.Collections.ObjectModel;

namespace Wpf_V4.Model
{
    internal class EmployeeDB
    {
        private static EmployeeDB _context;
        public static EmployeeDB Context => _context ?? (_context = new EmployeeDB());

        private EmployeeDB()
        {

        }

        public ObservableCollection<Employee> Employees = new ObservableCollection<Employee>()
        {
            new Employee()
            {
                Name = "Name1",
                Surname = "Surname1",
                Patronymic = "Patronymic1",
                PhoneNumber = "11-11-11",
                JobTitle = "JobTitle1",
                Departament = "Departament1",
                Login = "Login1",
                Password = "Password1",
                EMail = "@mail1.com"
            },
            new Employee()
            {
                Name = "Name2",
                Surname = "Surname2",
                Patronymic = "Patronymic2",
                PhoneNumber = "22-22-22",
                JobTitle = "JobTitle2",
                Departament = "Departament2",
                Login = "Login2",
                Password = "Password2",
                EMail = "@mail2.com"
            },
            new Employee()
            {
                Name = "Name3",
                Surname = "Surname3",
                Patronymic = "Patronymic3",
                PhoneNumber = "33-33-33",
                JobTitle = "JobTitle3",
                Departament = "Departament3",
                Login = "Login3",
                Password = "Password3",
                EMail = "@mail3.com"
            },
            new Employee()
            {
                Name = "Name4",
                Surname = "Surname4",
                Patronymic = "Patronymic4",
                PhoneNumber = "34-34-34",
                JobTitle = "JobTitle3",
                Departament = "Departament3",
                Login = "Login4",
                Password = "Password4",
                EMail = "@mail4.com"
            },
        };
    }
}
