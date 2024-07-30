using EmployeesInformation.DbContexts;
using EmployeesInformation.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace EmployeesInformation
{
    public class EmployeeDataStore
    {
        //public List<Employee>Employees { get; set; }

        //public EmployeeDataStore() {
        //    Employees = new List<Employee>
        //    {
        //        new Employee { Id = 1, Name = "John Doe", JobTitle = "Manager", Salary = 60000 },
        //        new Employee { Id = 2, Name = "Jane Smith", JobTitle = "Developer", Salary = 80000 },
        //        new Employee { Id = 3, Name = "Mike Johnson", JobTitle = "Analyst", Salary = 70000 },
        //        new Employee { Id = 4, Name = "Alice Brown", JobTitle = "Designer", Salary = 75000 },
        //        new Employee { Id = 5, Name = "Bob Davis", JobTitle = "Support", Salary = 50000 }
        //    };
        // }

        private readonly EmployeeDbContext _context;

        public EmployeeDataStore(EmployeeDbContext context)
        {
            _context = context;
        }

        public async Task<List<Employee>> GetEmployeesAsync()
        {
            return await _context.Employees.ToListAsync();
        }

        public async Task<Employee> GetEmployeeByIdAsync(int id)
        {
            return await _context.Employees.FindAsync(id);
        }
    }
}
