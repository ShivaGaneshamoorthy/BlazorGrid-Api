using EmployeeManagement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Api.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Seed Departments Table
            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 1, DepartmentName = "IT" });
            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 2, DepartmentName = "HR" });
            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 3, DepartmentName = "Payroll" });
            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 4, DepartmentName = "Admin" });

            // Seed Employee Table
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 1,
                Client = "ARMSOL",
                AgencyId = "003779345",
                AccountId = "200400ARS",
                FirstName = "John",
                LastName = "Hastings",
                Email = "David@yahoo.com",
                AccountStartDate = new DateTime(2020, 10, 5),
                RefferedAmount = 300.35,
                Balance = 200.00,
                Status = Status.JustOpened,
                StatusDate = new DateTime(2020, 10, 5),
                DateOfBrith = new DateTime(2020, 10, 5),
                Gender = Gender.Male,
                DepartmentId = 1
            });

            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 2,
                Client = "ARMSOL",
                AgencyId = "003779345",
                AccountId = "200400ARS",
                FirstName = "Sam",
                LastName = "Galloway",
                Email = "Sam@gmail.com",
                AccountStartDate = new DateTime(2020, 10, 5),
                RefferedAmount = 300.35,
                Balance = 200.00,
                Status = Status.JustOpened,
                StatusDate = new DateTime(2020, 10, 5),
                DateOfBrith = new DateTime(1981, 12, 22),
                Gender = Gender.Male,
                DepartmentId = 2
            });

            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 3,
                FirstName = "Mary",
                LastName = "Smith",
                Email = "mary@armsolutions.com",
                DateOfBrith = new DateTime(1979, 11, 11),
                Gender = Gender.Female,
                DepartmentId = 1
            });

            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 4,
                FirstName = "Sara",
                LastName = "Longway",
                Email = "sara@cognultsoft.com",
                DateOfBrith = new DateTime(1982, 9, 23),
                Gender = Gender.Female,
                DepartmentId = 3
            });
        }
    }
}
