namespace FullBrain.Models;

public class Checklist
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public string Title { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public User? User { get; set; }
    public List<ChecklistItem> Items { get; set; } = [];
}