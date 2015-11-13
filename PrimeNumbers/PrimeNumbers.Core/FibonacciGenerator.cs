using System.Collections;
using System.Collections.Generic;

namespace PrimeNumbers.Core
{
    public class FibonacciGenerator
    {
        public IEnumerable Generate(int numberOfItems)
        {
            if (numberOfItems == 1)
                return new[] { 1 };

            var sequence = new List<int>() { 1, 1 };
            if (numberOfItems == 2)
                return sequence;

            for (int i = 1; i < numberOfItems - 1; i++)
            {
                var currentSum = SumLastTwoNumbers(sequence[i - 1], sequence[i]);
                sequence.Add(currentSum);
            }

            return sequence;
        }

        private int SumLastTwoNumbers(int first, int second)
        {
            return first + second;
        }
    }
}