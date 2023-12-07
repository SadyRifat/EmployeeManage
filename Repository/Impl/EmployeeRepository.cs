using EmployeeManage.Data;
using EmployeeManage.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManage.Repository.Impl
{
    public class EmployeeRepository: IEmployeeRepository
    {
        private readonly ApplicationDbContext _context;

        public EmployeeRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _context.Employees.Include(e => e.Department).ToList();
        }

        public Employee GetEmployeeById(int employeeId)
        {
            return _context.Employees.Include(e => e.Department).FirstOrDefault(e => e.EmployeeID == employeeId);
        }

        public void AddEmployee(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
        }

        public void UpdateEmployee(Employee employee)
        {
            _context.Employees.Update(employee);
            _context.SaveChanges();
        }

        public void DeleteEmployee(int employeeId)
        {
            var employee = _context.Employees.Find(employeeId);
            if (employee != null)
            {
                _context.Employees.Remove(employee);
                _context.SaveChanges();
            }
        }
    }
}
