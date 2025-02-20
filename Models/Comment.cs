    public class Comment
    {
        public int Id { get; set; }
        public int TaskId { get; set; }
        public int EmployeeId { get; set; }
        public string CommentText { get; set; } // Renamed to avoid conflicts with C# reserved words
        public DateTime CreatedAt { get; set; }
    }
