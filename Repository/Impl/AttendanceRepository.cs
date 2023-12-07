using EmployeeManage.Data;
using EmployeeManage.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManage.Repository.Impl
{
    public class AttendanceRepository: IAttendanceRepository
    {
        private readonly ApplicationDbContext _context;

        public AttendanceRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Attendance> GetAllAttendances()
        {
            return _context.Attendances.Include(a => a.Employee).ToList();
        }

        public Attendance GetAttendanceById(int attendanceId)
        {
            return _context.Attendances.Include(a => a.Employee).FirstOrDefault(a => a.AttendanceID == attendanceId);
        }

        public void AddAttendance(Attendance attendance)
        {
            _context.Attendances.Add(attendance);
            _context.SaveChanges();
        }

        public void UpdateAttendance(Attendance attendance)
        {
            _context.Attendances.Update(attendance);
            _context.SaveChanges();
        }

        public void DeleteAttendance(int attendanceId)
        {
            var attendance = _context.Attendances.Find(attendanceId);
            if (attendance != null)
            {
                _context.Attendances.Remove(attendance);
                _context.SaveChanges();
            }
        }
    }
}
