public class LeaveRequest
{
    public int Id { get; set; }
    public int EmployeeId { get; set; } // Foreign key reference to Employee
    public string LeaveType { get; set; } // Enum stored as string (Sick, Casual, Paid, Unpaid)
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string Status { get; set; } // Enum stored as string (Pending, Approved, Rejected)
    public DateTime CreatedAt { get; set; }
}
