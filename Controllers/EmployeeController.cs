using EmployeeManagement.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeDBContext _context = new EmployeeDBContext();

        public EmployeeController(EmployeeDBContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Employees.ToList());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                _context.Employees.Add(employee);
                return RedirectToAction("Index");
            }
            return View(employee);
        }

        public IActionResult Edit(int id)
        {
            var employee = _context.Employees.FirstOrDefault(e => e.Id == id);
            return View(employee);
        }

        [HttpPost]
        public IActionResult Edit(Employee employee)
        {
            if (ModelState.IsValid)
            {
                var existingEmployee = _context.Employees.FirstOrDefault(e => e.Id == employee.Id);
                if (existingEmployee != null)
                {
                    existingEmployee.Name = employee.Name;
                    existingEmployee.Designation = employee.Designation;
                    existingEmployee.DateOfJoining = employee.DateOfJoining;
                    existingEmployee.Salary = employee.Salary;
                    existingEmployee.Gender = employee.Gender;
                    existingEmployee.State = employee.State;
                }
                else
                {
                    return Ok("Employee Record Doesn't Exist");
                }
            }
            else { return BadRequest(); }
            return View(employee);
        }

        public IActionResult Delete(int id)
        {
            var employee = _context.Employees.FirstOrDefault(e => e.Id == id);
            if (employee != null)
            {
                _context.Employees.Remove(employee);
            }
            return RedirectToAction("Index");
        }
    }

}
