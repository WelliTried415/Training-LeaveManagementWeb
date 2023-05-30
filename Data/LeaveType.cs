namespace Training_LeaveManagementWeb.Data
{
    public class LeaveType : BaseEntity //these are outlines for the actual db tables
    {
       
        public string Name { get; set; }
        public int DefaultDays { get; set; }
        
    }
}
