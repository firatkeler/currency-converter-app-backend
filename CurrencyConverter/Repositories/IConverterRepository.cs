using System;
namespace CurrencyConverter.Repositories
{
    public interface IConverterRepository
    {
        double Convert(double amount, string from, string to);
    }
}
