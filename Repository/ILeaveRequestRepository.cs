using EmployeeManage.Models;

namespace EmployeeManage.Repository
{
    public interface ILeaveRequestRepository
    {
        IEnumerable<LeaveRequest> GetAllLeaveRequests();
        LeaveRequest GetLeaveRequestById(int leaveRequestId);
        void AddLeaveRequest(LeaveRequest leaveRequest);
        void UpdateLeaveRequest(LeaveRequest leaveRequest);
        void DeleteLeaveRequest(int leaveRequestId);
    }
}
