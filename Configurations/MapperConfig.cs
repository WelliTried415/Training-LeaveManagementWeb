using AutoMapper;
using Training_LeaveManagementWeb.Data;
using Training_LeaveManagementWeb.Models;

namespace Training_LeaveManagementWeb.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig() 
        {
            CreateMap<LeaveType, LeaveTypeVM>().ReverseMap();
        }
    }
}
