using EmployeeManage.Data;
using EmployeeManage.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManage.Repository.Impl
{
    public class LeaveRequestRepository: ILeaveRequestRepository
    {
        private readonly ApplicationDbContext _context;

        public LeaveRequestRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<LeaveRequest> GetAllLeaveRequests()
        {
            return _context.LeaveRequests.Include(lr => lr.Employee).ToList();
        }

        public LeaveRequest GetLeaveRequestById(int leaveRequestId)
        {
            return _context.LeaveRequests.Include(lr => lr.Employee).FirstOrDefault(lr => lr.LeaveRequestID == leaveRequestId);
        }

        public void AddLeaveRequest(LeaveRequest leaveRequest)
        {
            _context.LeaveRequests.Add(leaveRequest);
            _context.SaveChanges();
        }

        public void UpdateLeaveRequest(LeaveRequest leaveRequest)
        {
            _context.LeaveRequests.Update(leaveRequest);
            _context.SaveChanges();
        }

        public void DeleteLeaveRequest(int leaveRequestId)
        {
            var leaveRequest = _context.LeaveRequests.Find(leaveRequestId);
            if (leaveRequest != null)
            {
                _context.LeaveRequests.Remove(leaveRequest);
                _context.SaveChanges();
            }
        }
    }
}
