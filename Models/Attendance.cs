public class Attendance
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; } // Foreign key
        public DateTime Date { get; set; }
        public string Status { get; set; } // Present, Absent, Leave
    }