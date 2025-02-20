public class Department
{
    public int Id { get; set; }
    public string Name { get; set; } // Unique department name
    public int? ManagerId { get; set; } // Nullable, as a department may not have a manager
}
