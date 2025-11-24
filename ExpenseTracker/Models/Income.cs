using System.ComponentModel.DataAnnotations.Schema;

namespace ExpenseTracker.Models
{
    public class Income
    {
        public int Id { get; set; }
        public required string Title { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public required decimal Amount { get; set; }

        public DateTimeOffset CreatedTimeStamp { get; set; }
    }
}
