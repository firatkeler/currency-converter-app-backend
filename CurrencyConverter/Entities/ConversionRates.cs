using System;
using System.Collections.Generic;

namespace CurrencyConverter.Entities
{
    public class ConversionRates
    {
        public List<ConversionRate> rates;

        public ConversionRates()
        {
            rates = new List<ConversionRate>
                            {
                                new ConversionRate {Base = "TRY", Target = "USD", Rate = 13.5},
                                new ConversionRate {Base = "TRY", Target = "EUR", Rate = 15},
                                new ConversionRate {Base = "TRY", Target = "GBP", Rate = 18},
                                new ConversionRate {Base = "TRY", Target = "TRY", Rate = 1},
                                new ConversionRate {Base = "USD", Target = "TRY", Rate = 0.07},
                                new ConversionRate {Base = "USD", Target = "EUR", Rate = 0.9},
                                new ConversionRate {Base = "USD", Target = "GBP", Rate = 0.75},
                                new ConversionRate {Base = "USD", Target = "USD", Rate = 1},
                                new ConversionRate {Base = "EUR", Target = "TRY", Rate = 0.06},
                                new ConversionRate {Base = "EUR", Target = "USD", Rate = 1.10},
                                new ConversionRate {Base = "EUR", Target = "GBP", Rate = 0.80},
                                new ConversionRate {Base = "EUR", Target = "EUR", Rate = 1},
                                new ConversionRate {Base = "GBP", Target = "TRY", Rate = 0.05},
                                new ConversionRate {Base = "GBP", Target = "USD", Rate = 1.34},
                                new ConversionRate {Base = "GBP", Target = "EUR", Rate = 1.20},
                                new ConversionRate {Base = "GBP", Target = "GBP", Rate = 1}
                            };
        }

        public double GetRate(string from, string to)
        {
            return rates.Find(o => o.Base == to && o.Target == from).Rate;
        }
    }
}
