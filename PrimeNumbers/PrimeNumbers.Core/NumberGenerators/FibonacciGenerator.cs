﻿using System.Collections;
using System.Collections.Generic;
using PrimeNumbers.Contracts;

namespace PrimeNumbers.Core.NumberGenerators
{
    public class FibonacciGenerator : INumbersGenerator
    {
        public IEnumerable<int> Generate(int numberOfItems)
        {
            if (numberOfItems <= 0)
                return new int[0];

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