using EmployeeManage.Models;

namespace EmployeeManage.Repository
{
    public interface IDepartmentRepository
    {
        IEnumerable<Department> GetAllDepartments();
        Department GetDepartmentById(int departmentId);
        void AddDepartment(Department department);
        void UpdateDepartment(Department department);
        void DeleteDepartment(int departmentId);
    }
}
