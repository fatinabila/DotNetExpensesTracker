using ExpenseTracker.Data;
using ExpenseTracker.Models.References;
using Microsoft.EntityFrameworkCore;

namespace ExpenseTracker.Services
{
    public class ReferenceService : IReferenceService
    {
        private readonly ExpenseTrackerDbContext _context;
        public ReferenceService(ExpenseTrackerDbContext context)
        {
            _context = context;
        }
        public async Task<List<Category>> GetCategoriesAsync()
        {
            // Implementation to retrieve categories
            return await _context.Categories.ToListAsync();
        }   

        public async Task<List<Currency>> GetCurrenciesAsync()
        {
            return await _context.Currencies.ToListAsync(); 
        }
    }
}
