using ExpenseTracker.Models.References;

namespace ExpenseTracker.Services
{
    public interface IReferenceService
    {

        Task<List<Category>> GetCategoriesAsync();

        Task<List<Currency>> GetCurrenciesAsync();
    }
}
