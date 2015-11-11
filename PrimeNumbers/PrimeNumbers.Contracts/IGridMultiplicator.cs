using System.Collections.Generic;

namespace PrimeNumbers.Contracts
{
    public interface IGridMultiplicator
    {
        int[,] Calculate(List<int> numbers);
    }
}