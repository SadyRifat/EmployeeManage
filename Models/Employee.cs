namespace EmployeeManage.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime JoinDate { get; set; }
        public int DepartmentID { get; set; }

        // Navigation properties
        public Department Department { get; set; }
        public List<Attendance> Attendances { get; set; }
        public List<LeaveRequest> LeaveRequests { get; set; }
    }
}
