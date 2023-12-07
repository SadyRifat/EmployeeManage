using EmployeeManage.Models;

namespace EmployeeManage.ViewModel
{
    public class EmployeeViewModel
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int DepartmentID { get; set; }

        // Navigation properties
        public Department Department { get; set; }
    }
}
