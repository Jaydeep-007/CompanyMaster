using EmployeeMaster.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace EmployeeMaster.Data
{
    public class EmployeeDbContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public EmployeeDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}
