using ExpenseTracker.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExpenseTracker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReferenceController : ControllerBase
    {

        private readonly IReferenceService _referenceService;

        public ReferenceController(IReferenceService referenceService)
        {
            _referenceService = referenceService;
        }


        [HttpGet("Categories")]
        public async Task<IActionResult> GetCategories()
        {
            var categories = await _referenceService.GetCategoriesAsync();
            return Ok(categories);
        }

        [HttpGet("Currencies")]
        public async Task<IActionResult> GetCurrencies()
        {
            var currencies = await _referenceService.GetCurrenciesAsync();
            return Ok(currencies);
        }
    }
}
