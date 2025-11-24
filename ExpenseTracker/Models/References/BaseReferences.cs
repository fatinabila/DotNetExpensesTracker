namespace ExpenseTracker.Models.References
{
    public class BaseReference
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
    }
}
