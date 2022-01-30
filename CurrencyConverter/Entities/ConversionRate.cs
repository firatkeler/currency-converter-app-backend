using System;
using System.Collections.Generic;

namespace CurrencyConverter.Entities
{

    public class ConversionRate
    {
        public string Base { get; set; }
        public string Target { get; set; }
        public double Rate { get; set; }
    }
}
