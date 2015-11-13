using NSubstitute;
using PrimeNumbers.Contracts;
using PrimeNumbers.Core;

namespace PrimeNumbers.Tests.Common.Builders
{
    public class PrimeNumberEngineBuilder
    {
        private int primeNumbersToGenerate = 1;
        private INumbersGenerator generator;
        private IGridMultiplicator gridMultiplicator;
        private IArrayFormatter formatter;

        public PrimeNumberEngineBuilder()
        {
            generator = Substitute.For<INumbersGenerator>();
            gridMultiplicator = Substitute.For<IGridMultiplicator>();
            formatter = Substitute.For<IArrayFormatter>();
        }

        public PrimeNumberEngineBuilder WithGenerator(INumbersGenerator newGenerator)
        {
            generator = newGenerator;
            return this;
        }

        public PrimeNumberEngineBuilder WithGridMultiplicator(IGridMultiplicator newGridMultiplicator)
        {
            gridMultiplicator = newGridMultiplicator;
            return this;
        }

        public PrimeNumberEngineBuilder WithFormatter(IArrayFormatter newformatter)
        {
            formatter = newformatter;
            return this;
        }

        public PrimeNumberEngine Build()
        {
            return new PrimeNumberEngine(generator, gridMultiplicator, formatter);
        }
    }
}
