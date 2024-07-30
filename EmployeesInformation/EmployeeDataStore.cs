using EmployeesInformation.Models;

namespace EmployeesInformation
{
    public class EmployeeDataStore
    {
        public List<Employee>Employees { get; set; }

        public EmployeeDataStore() {
            Employees = new List<Employee>
            {
                new Employee { Id = 1, Name = "John Doe", JobTitle = "Manager", Salary = 60000 },
                new Employee { Id = 2, Name = "Jane Smith", JobTitle = "Developer", Salary = 80000 },
                new Employee { Id = 3, Name = "Mike Johnson", JobTitle = "Analyst", Salary = 70000 },
                new Employee { Id = 4, Name = "Alice Brown", JobTitle = "Designer", Salary = 75000 },
                new Employee { Id = 5, Name = "Bob Davis", JobTitle = "Support", Salary = 50000 }
            };
        }
    }
}
