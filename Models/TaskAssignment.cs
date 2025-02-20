 public class TaskAssignment
    {
        public int Id { get; set; }
        public int TaskId { get; set; } // Foreign key
        public int EmployeeId { get; set; } // Foreign key
        public DateTime AssignedDate { get; set; }
    }