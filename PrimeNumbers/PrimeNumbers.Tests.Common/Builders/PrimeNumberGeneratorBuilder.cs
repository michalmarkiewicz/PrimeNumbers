using PrimeNumbers.Core;
using PrimeNumbers.Core.NumberGenerators;

namespace PrimeNumbers.Tests.Common.Builders
{
    public class PrimeNumberGeneratorBuilder
    {
        public int NumberOfPrimes { get; private set; }

        public PrimeNumberGeneratorBuilder()
        {
            NumberOfPrimes = 1;
        }

        public PrimeNumberGeneratorBuilder WithPrimeNumbers(int newNumberOfPrimes)
        {
            NumberOfPrimes = newNumberOfPrimes;
            return this;
        }

        public PrimeGenerator Build()
        {
            return new PrimeGenerator(NumberOfPrimes);
        }
    }
}