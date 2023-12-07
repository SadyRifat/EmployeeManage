using EmployeeManage.Models;

namespace EmployeeManage.Repository
{
    public interface IAttendanceRepository
    {
        IEnumerable<Attendance> GetAllAttendances();
        Attendance GetAttendanceById(int attendanceId);
        void AddAttendance(Attendance attendance);
        void UpdateAttendance(Attendance attendance);
        void DeleteAttendance(int attendanceId);
    }
}
