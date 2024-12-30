using System;
using System.Collections.Generic;
using CoreLibrary.Models;
using DataLayer;
using DataLayer.DataContext;

namespace DataLayer
{
    public class EmployeeDL
    {

        private readonly AppDbContext _appDbContext;
        Employee objEmployee = new Employee();
        List<Employee> objEmpList = new List<Employee>();

        public EmployeeDL(AppDbContext appDbContext)
        {
            this._appDbContext= appDbContext;
        }

         public List<Employee> GetAllEmployees()
        {
            //objEmpList = AppDbContext.Employee.ToList();
            _appDbContext.Employee.ToList();
            return objEmpList;
        }
    }
}

//    List<Employee> emp = new List<Employee>()
//{
//    new Employee { Id = 1, Name = "John doe", Position = "developer", Department = "IT", Email="Johndeo123@gmail.com", PhoneNo="9873210846", DOB=DateTime.Parse("2023-09-12") },
//    new Employee { Id = 2, Name = "Jane smith", Position = "manager", Department = "HR", Email="Janesmith123@gmail.com", PhoneNo="1234567890", DOB=DateTime.Parse("2001-05-30") },
//    new Employee { Id = 3, Name = "Sam brown", Position = "designer", Department = "Marketing", Email="sambrown@gmail.com", PhoneNo="9876543210", DOB=DateTime.Parse("1975-11-25")   },
//    new Employee { Id = 4, Name = "Nancy white", Position = "accountant", Department = "Finance", Email="nancywhite123@gmail.com", PhoneNo="9865342145", DOB=DateTime.Parse("1995-12-10") },
//    new Employee { Id = 5, Name = "Michael green", Position = "developer", Department = "IT", Email="michaelgreen@gmail.com",PhoneNo="9712345679", DOB=DateTime.Parse("1966-09-12") },
//    new Employee { Id = 6, Name = "Emma black", Position = "manager", Department = "HR", Email="emmablack@gmail.com", PhoneNo="1234567890", DOB=DateTime.Parse("1999-05-13") },
//    new Employee { Id = 7, Name = "Oliver blue", Position = "designer", Department = "Marketing", Email="Oliverblue@gmail.com", PhoneNo="2345678901", DOB=DateTime.Parse("2000-04-15") },
//    new Employee { Id = 8, Name = "Sophia gray", Position = "accountant", Department = "Finance", Email="sophiagray@gmail.com", PhoneNo="9875432309", DOB=DateTime.Parse("1989-06-25") },
//    new Employee { Id = 9, Name = "Liam brown", Position = "developer", Department = "IT", Email="liambrown@gmail.com", PhoneNo="9842356780", DOB=DateTime.Parse("2002-07-12") },
//    new Employee { Id = 10, Name = "Ava white", Position = "manager", Department = "HR", Email="avawhite@gmail.com", PhoneNo="9876543210", DOB=DateTime.Parse("203-11-15") }
//};
//    return emp;