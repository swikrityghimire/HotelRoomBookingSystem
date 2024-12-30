using BusinessLayer;
using CoreLibrary.Models;
using DataLayer;
using DataLayer.DataContext;
using Microsoft.AspNetCore.Mvc;

namespace HotelRoomBooking.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly EmployeeBL _employeeBL;
        //private object Employee;

        //GET: EmployeeController
        public EmployeeController(AppDbContext appDbContext)
        {
            _employeeBL = new EmployeeBL(appDbContext);
        }

        // GET: /<controller>/
        public ActionResult Index()     
        {
            List<Employee> objEmpList = _employeeBL.GetAllEmployees().ToList();
            return View(objEmpList);
        }
        //}
        // GET: EmployeeController/Details/5
        //public ActionResult Details(int Id, Employee obj)
        //{
        //        return View(Emp);
        //}

        // GET: EmployeeController/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        // POST: EmployeeController/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(Employee objemployee)
        //{
        //    try
        //    {
        //        employee.Add(objemployee);
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        // GET: EmployeeController/Edit/5
        //public ActionResult Edit(int Id)
        //{
        //    var employee = GetEmployeeById(Id);
        //    if (employee != null)
        //    {
        //        return View(employee);
        //    }
        //    return NotFound();
        //}

        // POST: EmployeeController/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int Id, Employee editEmployee)
        //{
        //    try
        //    {
        //        var emp = GetEmployeeById(Id);
        //        if (emp != null)
        //        {
        //            emp.Name = editEmployee.Name;
        //            emp.Position = editEmployee.Position;
        //            emp.Department = editEmployee.Department;
        //            emp.Email = editEmployee.Email;
        //            emp.PhoneNo = editEmployee.PhoneNo;
        //            emp.DOB = editEmployee.DOB;

        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //    private object GetEmployeeById(int id)
        //    {
        //        throw new NotImplementedException();
        //    }

        //    private object GetEmployeeById(int id)
        //    {
        //        throw new NotImplementedException();
        //    }
        //}

        // GET: EmployeeController/Delete/5
        //public ActionResult Delete(int Id)
        //    {
        //        var employee = GetEmployeeById(Id);
        //        if (employee != null)
        //        {
        //        return View(employee);
        //        }
        //        return NotFound();
        //    }

        // POST: EmployeeController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int Id, IFormCollection collection)
        //{
        //    try
        //    {
        //        var employee = GetEmployeeById(Id);
        //        if (employee != null)
        //        {
        //            employee.Remove(employee);
        //        }     
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //private Employee GetEmployeeById(int id)
        //{
        //    return employee.FirstOrDefault(e => e.Id == id);
        //}
    }
}