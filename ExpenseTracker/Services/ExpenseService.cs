using ExpenseTracker.Data;
using ExpenseTracker.Models;
using Microsoft.EntityFrameworkCore;

namespace ExpenseTracker.Services
{
    public class ExpenseService : IExpenseService
    {
        private readonly ExpenseTrackerDbContext _context;

        public ExpenseService(ExpenseTrackerDbContext context)
        {
            _context = context;
        }

        public async Task<List<Expenses>> GetExpensesAsync()
        {
            return await _context.Expenses.ToListAsync();
        }

        public async Task<Expenses?> GetExpenseByIdAsync(int id)
        {
            return await _context.Expenses.FindAsync(id);
        }

        public async Task<Expenses> CreateExpenseAsync(Expenses expense)
        {
            
            expense.CreatedTimeStamp = DateTimeOffset.UtcNow;
            expense.Id = 0;

            _context.Expenses.Add(expense);
            await _context.SaveChangesAsync();
            return expense; 
        }

        public async Task<Expenses?> UpdateExpenseAsync(int id, Expenses expense)
        {
            var existingExpense = await _context.Expenses.FindAsync(id);
            if (existingExpense == null)
                return null;

            existingExpense.Title = expense.Title;
            existingExpense.Amount = expense.Amount;
            existingExpense.Category = expense.Category;
            existingExpense.Currency = expense.Currency;
            // Don't update Id or CreatedTimeStamp during updates

            await _context.SaveChangesAsync();
            return existingExpense;
        }

        public async Task<bool> DeleteExpenseAsync(int id)
        {
            var expense = await _context.Expenses.FindAsync(id);
            if (expense == null)
                return false;

            _context.Expenses.Remove(expense);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}