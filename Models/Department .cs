namespace EmployeeManage.Models
{
    public class Department
    {
        public int DepartmentID { get; set; }
        public string DepartmentName { get; set; }

        // Navigation property
        public List<Employee> Employees { get; set; }
    }
}
