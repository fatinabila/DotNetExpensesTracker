using ExpenseTracker.Models;

namespace ExpenseTracker.Services
{
    public interface IIncomeService
    {
        Task<List<Income>> GetIncomesAsync();
        Task<Income?> GetIncomeByIdAsync(int id);
        Task<Income> CreateIncomeAsync(Income income);
        Task<Income?> UpdateIncomeAsync(int id, Income income);
        Task<bool> DeleteIncomeAsync(int id);
    }
}