namespace Training_LeaveManagementWeb.Data
{
    public abstract class BaseEntity //partial so it can't be instatiated by itself
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
    }
}
