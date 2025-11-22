using ExpenseTracker.Models;

namespace ExpenseTracker.Services
{
    public interface IExpenseService
    {
        Task<List<Expenses>> GetExpensesAsync();
        Task<Expenses?> GetExpenseByIdAsync(int id);
        Task<Expenses> CreateExpenseAsync(Expenses expense);
        Task<Expenses?> UpdateExpenseAsync(int id, Expenses expense);
        Task<bool> DeleteExpenseAsync(int id);
    }
}