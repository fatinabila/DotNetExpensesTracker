using System.ComponentModel.DataAnnotations.Schema;

namespace ExpenseTracker.Models
{
    public class Expenses
    {
        public int Id { get; set; }
        public required string Title { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public required decimal Amount { get; set; }        

        public int? CategoryId { get; set; }  // Foreign key
        public string? Category { get; set; }  // Keep for backward compatibility if needed

        public DateTimeOffset CreatedTimeStamp { get; set; }

        public string? Currency { get; set; } = "MYR";
    }
}
