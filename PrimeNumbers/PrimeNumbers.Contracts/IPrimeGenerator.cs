using System.Collections.Generic;

namespace PrimeNumbers.Contracts
{
    public interface IPrimeGenerator
    {
        bool IsPrime(int number);
        IEnumerable<int> Generate(int fromNumber);
    }
}