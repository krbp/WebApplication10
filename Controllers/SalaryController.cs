using Microsoft.AspNetCore.Mvc;
using WebApplication10.Services;

namespace WebApplication10.Controllers
{
    [Route("api/[controller]")]
    public class SalaryController : Controller
    {
        private ISalaryCalculator _calculator;

        public SalaryController(ISalaryCalculator injectedCalculator)
        {
            _calculator = injectedCalculator;
        }

        [HttpGet("{yearlyAmount}")]
        public Double Get(Double yearlyAmount)
        {
            Double calculatedSalary = _calculator.CalculateSalary(yearlyAmount);
            return calculatedSalary;
        }
    }
}
