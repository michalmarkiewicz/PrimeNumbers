using PrimeNumbers.Core;

namespace PrimeNumbers.Tests.Common.Builders
{
    public class PrimeNumberGeneratorBuilder
    {
        private PrimeNumberGenerator generator;

        public PrimeNumberGenerator Build()
        {
            return new PrimeNumberGenerator();
        }
    }
}