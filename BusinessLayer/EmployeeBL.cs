using System;
using CoreLibrary.Models;
using DataLayer;
using DataLayer.DataContext;

namespace BusinessLayer
{
    public class EmployeeBL
    {

        private readonly EmployeeDL _employeeDl;// = new EmployeeDL();

    public EmployeeBL(AppDbContext appDbContext)
        {
            _employeeDl = new EmployeeDL(appDbContext);
        }
        
        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeeDl.GetAllEmployees();
        }
    }
}