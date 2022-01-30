using System;
using System.Collections.Generic;
using CurrencyConverter.Entities;

namespace CurrencyConverter.Repositories
{
    public class ConverterRepository : IConverterRepository
    {
        public double Convert(double amount, string from, string to)
        {
            ConversionRates cr = new ConversionRates();

            return amount * cr.GetRate(from, to);
        }
    }
}
