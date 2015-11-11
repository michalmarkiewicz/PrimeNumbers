using System.Collections.Generic;

namespace PrimeNumbers.Contracts
{
    public interface IPrimeNumberGenerator
    {
        bool IsPrime(int number);
        IEnumerable<int> Generate(int fromNumber);
    }
}