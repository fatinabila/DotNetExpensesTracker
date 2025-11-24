using System.ComponentModel.DataAnnotations.Schema;

namespace ExpenseTracker.Models
{
    public class Expense
    {
        public int Id { get; set; }
        public required string Title { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public required decimal Amount { get; set; }        

        public int? CategoryId { get; set; }  
        public string? Category { get; set; } 

        public DateTimeOffset CreatedTimeStamp { get; set; }

        public string? Currency { get; set; } = "MYR";
    }
}
