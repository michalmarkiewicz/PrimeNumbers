using System.Collections.Generic;

namespace PrimeNumbers.Contracts
{
    public interface INumbersGenerator
    {
        IEnumerable<int> Generate(int fromNumber);
    }
}