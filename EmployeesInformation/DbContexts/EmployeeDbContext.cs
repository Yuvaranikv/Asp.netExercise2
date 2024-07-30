using EmployeesInformation.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace EmployeesInformation.DbContexts
{
    public class EmployeeDbContext :DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options)
            : base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
