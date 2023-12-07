namespace EmployeeManage.Models
{
    public class Attendance
    {
        public int AttendanceID { get; set; }
        public int EmployeeID { get; set; }
        public DateTime AttendanceDate { get; set; }
        public DateTime ClockInTime { get; set; }
        public DateTime ClockOutTime { get; set; }

        // Navigation property
        public Employee Employee { get; set; }

    }
}
