using System;
using CurrencyConverter.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CurrencyConverter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CurrencyController: ControllerBase
    {
        private IConverterRepository members = new ConverterRepository();

        [HttpGet("amount={amount}&from={from}&to={to}")]
        public ActionResult<double> Convert(double amount, string from, string to)
        {
            return members.Convert(amount, from, to);
        }
    }
}
