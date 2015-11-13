using NSubstitute;
using PrimeNumbers.Contracts;
using PrimeNumbers.Core;

namespace PrimeNumbers.Tests.Common.Builders
{
    public class NumbersEngineBuilder
    {
        private INumbersGenerator generator;
        private IGridMultiplicator gridMultiplicator;
        private IArrayFormatter formatter;

        public NumbersEngineBuilder()
        {
            generator = Substitute.For<INumbersGenerator>();
            gridMultiplicator = Substitute.For<IGridMultiplicator>();
            formatter = Substitute.For<IArrayFormatter>();
        }

        public NumbersEngineBuilder WithGenerator(INumbersGenerator newGenerator)
        {
            generator = newGenerator;
            return this;
        }

        public NumbersEngineBuilder WithGridMultiplicator(IGridMultiplicator newGridMultiplicator)
        {
            gridMultiplicator = newGridMultiplicator;
            return this;
        }

        public NumbersEngineBuilder WithFormatter(IArrayFormatter newformatter)
        {
            formatter = newformatter;
            return this;
        }

        public NumbersEngine Build()
        {
            return new NumbersEngine(generator, gridMultiplicator, formatter);
        }
    }
}
