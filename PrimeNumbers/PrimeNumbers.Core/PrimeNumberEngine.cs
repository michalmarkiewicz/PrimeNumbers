﻿using System.Linq;
using PrimeNumbers.Contracts;

namespace PrimeNumbers.Core
{
    public class PrimeNumberEngine
    {
        private readonly IPrimeNumberGenerator generator;
        private readonly IGridMultiplicator multiplicator;
        private readonly IArrayFormatter formatter;

        public PrimeNumberEngine(IPrimeNumberGenerator generator, IGridMultiplicator multiplicator, IArrayFormatter formatter)
        {
            this.generator = generator;
            this.multiplicator = multiplicator;
            this.formatter = formatter;
        }

        public string GetPrimes(int primesAfterNumber)
        {
            var primes = generator.Generate(primesAfterNumber).ToList();
            var grid = multiplicator.Calculate(primes);

            return formatter.Formatt(grid);
        }
    }
}