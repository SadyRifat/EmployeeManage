using EmployeeManage.Models;

namespace EmployeeManage.Service
{
    public interface IDepartmentService
    {
        IEnumerable<Department> GetAllDepartments();
        Department GetDepartmentById(int departmentId);
        void AddDepartment(Department department);
        void UpdateDepartment(Department department);
        void DeleteDepartment(int departmentId);
    }
}
