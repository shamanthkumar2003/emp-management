public class Salary
{
    public int Id { get; set; }
    public int EmployeeId { get; set; } // Foreign key reference to Employee
    public decimal Amount { get; set; }
    public DateTime PayDate { get; set; }
    public DateTime CreatedAt { get; set; }
}
