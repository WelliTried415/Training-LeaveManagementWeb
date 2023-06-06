using Training_LeaveManagementWeb.Data;

namespace Training_LeaveManagementWeb.Contracts
{
    public interface ILeaveAllocationRepository : IGenericRepository<LeaveAllocation>
    {
        Task LeaveAllocation(int leaveTypeId);
        Task<bool> AllocationExists(string employeeId, int leaveTypeId, int period);
    }
}
