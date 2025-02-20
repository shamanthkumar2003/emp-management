 public class Salary
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; } // Foreign key
        public decimal Amount { get; set; }
        public DateTime DateIssued { get; set; }
    }