   public class Attendance
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime? CheckOut { get; set; } // Nullable to handle NULL values
        public string Status { get; set; } // Enum stored as string
        public DateTime CreatedAt { get; set; }
    }