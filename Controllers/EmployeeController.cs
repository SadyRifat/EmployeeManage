using EmployeeManage.Models;
using EmployeeManage.Service;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManage.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;
        private readonly IDepartmentService _departmentService;

        public EmployeeController(IEmployeeService employeeService, IDepartmentService departmentService)
        {
            _employeeService = employeeService;
            _departmentService = departmentService;
        }
        public IActionResult Index()
        {
            var employees = _employeeService.GetAllEmployees();
            return View(employees);
        }

        public IActionResult Create()
        {
            ViewBag.Departments = _departmentService.GetAllDepartments();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Employee employee)
        {
            employee.JoinDate = DateTime.Now;
            _employeeService.AddEmployee(employee);
            return RedirectToAction(nameof(Index));
            //if (ModelState.IsValid)
            //{
                
            //}
            //ViewBag.Departments = _departmentService.GetAllDepartments();
            //return View(employee);
        }

        public IActionResult Edit(int id)
        {
            var employee = _employeeService.GetEmployeeById(id);

            if (employee == null)
            {
                return NotFound();
            }

            ViewBag.Departments = _departmentService.GetAllDepartments();
            return View(employee);
        }


        [HttpPost]
        public IActionResult Edit(int id, Employee employee)
        {
            if (id != employee.EmployeeID)
            {
                return NotFound();
            }

            _employeeService.UpdateEmployee(employee);
            return RedirectToAction("Index", "Employee");
            //if (ModelState.IsValid)
            //{

            //}

            //ViewBag.Departments = _departmentService.GetAllDepartments();
            //return View(employee);
        }
    }
}
