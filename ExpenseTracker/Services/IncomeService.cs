using ExpenseTracker.Data;
using ExpenseTracker.Models;
using Microsoft.EntityFrameworkCore;

namespace ExpenseTracker.Services
{
    public class IncomeService : IIncomeService
    {
        private readonly ExpenseTrackerDbContext _context;

        public IncomeService(ExpenseTrackerDbContext context)
        {
            _context = context;
        }

        public async Task<List<Income>> GetIncomesAsync()
        {
            return await _context.Incomes.ToListAsync();
        }

        public async Task<Income?> GetIncomeByIdAsync(int id)
        {
            return await _context.Incomes.FindAsync(id);
        }

        public async Task<Income> CreateIncomeAsync(Income income)
        {
            // Reset Id to ensure new record creation
            income.CreatedTimeStamp = DateTimeOffset.UtcNow;
            income.Id = 0;

            _context.Incomes.Add(income);
            await _context.SaveChangesAsync();
            return income;
        }

        public async Task<Income?> UpdateIncomeAsync(int id, Income income)
        {
            var existingIncome = await _context.Incomes.FindAsync(id);
            if (existingIncome == null)
                return null;

            existingIncome.Title = income.Title;
            existingIncome.Amount = income.Amount;

            await _context.SaveChangesAsync();
            return existingIncome;
        }

        public async Task<bool> DeleteIncomeAsync(int id)
        {
            var income = await _context.Incomes.FindAsync(id);
            if (income == null)
                return false;

            _context.Incomes.Remove(income);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}