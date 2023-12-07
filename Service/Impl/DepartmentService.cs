using EmployeeManage.Models;
using EmployeeManage.Repository;

namespace EmployeeManage.Service.Impl
{
    public class DepartmentService: IDepartmentService
    {
        private readonly IDepartmentRepository _departmentRepository;

        public DepartmentService(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }

        public IEnumerable<Department> GetAllDepartments()
        {
            return _departmentRepository.GetAllDepartments();
        }

        public Department GetDepartmentById(int departmentId)
        {
            return _departmentRepository.GetDepartmentById(departmentId);
        }

        public void AddDepartment(Department department)
        {
            _departmentRepository.AddDepartment(department);
        }

        public void UpdateDepartment(Department department)
        {
            _departmentRepository.UpdateDepartment(department);
        }

        public void DeleteDepartment(int departmentId)
        {
            _departmentRepository.DeleteDepartment(departmentId);
        }
    }
}
