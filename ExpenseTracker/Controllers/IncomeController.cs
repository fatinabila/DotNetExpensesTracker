using ExpenseTracker.Models;
using ExpenseTracker.Services;
using Microsoft.AspNetCore.Mvc;

namespace ExpenseTracker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IncomeController : ControllerBase
    {
        private readonly IIncomeService _incomeService;

        public IncomeController(IIncomeService incomeService)
        {
            _incomeService = incomeService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Income>>> GetIncomes()
        {
            var incomes = await _incomeService.GetIncomesAsync();
            return Ok(incomes);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Income>> GetIncome(int id)
        {
            var income = await _incomeService.GetIncomeByIdAsync(id);
            if (income == null)
                return NotFound();

            return Ok(income);
        }

        [HttpPost]
        public async Task<ActionResult<Income>> CreateIncome(Income income)
        {
            var createdIncome = await _incomeService.CreateIncomeAsync(income);
            return CreatedAtAction(nameof(GetIncome), new { id = createdIncome.Id }, createdIncome);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateIncome(int id, Income income)
        {
            var updatedIncome = await _incomeService.UpdateIncomeAsync(id, income);
            if (updatedIncome == null)
                return NotFound();

            return Ok(updatedIncome);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteIncome(int id)
        {
            var deleted = await _incomeService.DeleteIncomeAsync(id);
            if (!deleted)
                return NotFound();

            return NoContent();
        }
    }
}
