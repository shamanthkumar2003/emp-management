    public class TaskHistory
    {
        public int Id { get; set; }
        public int TaskId { get; set; }
        public int ChangedBy { get; set; }
        public string OldStatus { get; set; } // Enum stored as string
        public string NewStatus { get; set; } // Enum stored as string
        public DateTime ChangedAt { get; set; }
    }
