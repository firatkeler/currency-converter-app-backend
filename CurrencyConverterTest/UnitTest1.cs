using System;
using Xunit;
using CurrencyConverter;
using CurrencyConverter.Entities;

namespace CurrencyConverterTest
{
    public class UnitTest1
    {
        [Fact]
        public void Be_able_to_convert()
        {
            double amount = 2;
            string from = "EUR";
            string to = "TRY";

            ConversionRates cr = new ConversionRates();
            
            double result = amount * cr.GetRate(from, to);

            Assert.Equal(30, result);
        }
    }
}
