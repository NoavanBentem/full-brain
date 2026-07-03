namespace FullBrain.Models;

public class ChecklistItem
{
    public int Id { get; set; }
    public int ChecklistId { get; set; }
    public string Title { get; set; } = string.Empty;
    public string? Notes { get; set; }
    public bool Completed { get; set; }
    public int Position { get; set; }
    public Checklist? Checklist { get; set; }
}