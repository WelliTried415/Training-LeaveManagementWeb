using Training_LeaveManagementWeb.Contracts;
using Training_LeaveManagementWeb.Data;

namespace Training_LeaveManagementWeb.Repositories
{
    public class LeaveTypeRepository : GenericRepository<LeaveType>, ILeaveTypeRepository
    {
        public LeaveTypeRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
