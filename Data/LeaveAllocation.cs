using System.ComponentModel.DataAnnotations.Schema;

namespace Training_LeaveManagementWeb.Data
{
    public class LeaveAllocation : BaseEntity
    {
        
        public int NumberOfDays { get; set; }


        //creation of foreign key this is the explicit way to establish a foreign key: [ForeignKey("LeaveTypeID")] 
        [ForeignKey("LeaveTypeID")]
        public LeaveType LeaveType { get; set; } //create property of table you want a foreign key for
        public int LeaveTypeID { get; set; } //the field of the table that we want as our foreign key with both of these, entitry framework should recognize theses fields as a foreign key

        public string EmployeeID { get; set; }
        public int Period { get; set; }
    }
}
