using ExpenseTracker.Models;
using Microsoft.EntityFrameworkCore;

namespace ExpenseTracker.Data
{
    public class ExpenseTrackerDbContext : DbContext
    {
        
        public ExpenseTrackerDbContext(DbContextOptions<ExpenseTrackerDbContext> options) : base(options)
        {
        }
        public DbSet<Expenses> Expenses { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed Categories
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Food" },
                new Category { Id = 2, Name = "Utilities" },
                new Category { Id = 3, Name = "Entertainment" },
                new Category { Id = 4, Name = "Transportation" },
                new Category { Id = 5, Name = "Healthcare" },
                new Category { Id = 6, Name = "Other" }
            );

            modelBuilder.Entity<Expenses>().HasData(
                new Expenses { Id = 1, Title = "Grocery Shopping", Amount = 150.75M, CategoryId = 1, CreatedTimeStamp = DateTimeOffset.Now.AddDays(-2) },
                new Expenses { Id = 2, Title = "Electricity Bill", Amount = 60.00M, CategoryId = 2, CreatedTimeStamp = DateTimeOffset.Now.AddDays(-10) },
                new Expenses { Id = 3, Title = "Movie Night", Amount = 30.50M, CategoryId = 3, CreatedTimeStamp = DateTimeOffset.Now.AddDays(-5) }
            );

            // Configure relationship
            modelBuilder.Entity<Expenses>()
                .HasOne<Category>()
                .WithMany()
                .HasForeignKey(e => e.CategoryId);
        }
    }
}
