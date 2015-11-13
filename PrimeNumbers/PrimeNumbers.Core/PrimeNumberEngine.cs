using System;
using System.Linq;
using PrimeNumbers.Contracts;

namespace PrimeNumbers.Core
{
    public class PrimeNumberEngine : IPrimeNumberEngine
    {
        private readonly INumbersGenerator generator;
        private readonly IGridMultiplicator multiplicator;
        private readonly IArrayFormatter formatter;

        public PrimeNumberEngine(INumbersGenerator generator, IGridMultiplicator multiplicator, IArrayFormatter formatter)
        {
            if (generator == null) throw new ArgumentNullException(nameof(generator));
            if (multiplicator == null) throw new ArgumentNullException(nameof(multiplicator));
            if (formatter == null) throw new ArgumentNullException(nameof(formatter));

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