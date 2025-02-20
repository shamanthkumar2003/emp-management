public class Job
{
    public int Id { get; set; }
    public string Title { get; set; }
    public decimal? MinSalary { get; set; } // Nullable to match database schema
    public decimal? MaxSalary { get; set; } // Nullable to match database schema
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}
