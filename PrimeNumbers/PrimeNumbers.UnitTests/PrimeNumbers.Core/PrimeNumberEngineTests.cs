using System;
using NSubstitute;
using NUnit.Framework;
using PrimeNumbers.Contracts;
using PrimeNumbers.Core;
using PrimeNumbers.Tests.Common.Builders;

namespace PrimeNumbers.UnitTests.PrimeNumbers.Core
{
    [TestFixture]
    public class PrimeNumberEngineTests
    {
        [Test]
        public void GetPrimes_ReadStringValue_GenerateOnePrimesAndFormattGridToString()
        {
            var expected = " \t2\r\n2\t4";
            var generator = Substitute.For<IPrimeNumberGenerator>();
            var multiplicator = Substitute.For<IGridMultiplicator>();
            var formatter = Substitute.For<IArrayFormatter>();
            formatter.Formatt(null).ReturnsForAnyArgs(x => " \t2\r\n2\t4");
            var sut = new PrimeNumberEngine(generator, multiplicator, formatter);

            var result = sut.GetPrimes(1);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void GetPrimes_ReadStringValue_GenerateThreePrimesAndFormattGridToString()
        {
            var expected = " \t2\t3\r\n2\t4\t6\r\n3\t6\t9";
            var generator = Substitute.For<IPrimeNumberGenerator>();
            var multiplicator = Substitute.For<IGridMultiplicator>();
            var formatter = Substitute.For<IArrayFormatter>();
            formatter.Formatt(null).ReturnsForAnyArgs(x => " \t2\t3\r\n2\t4\t6\r\n3\t6\t9");
            var sut = new PrimeNumberEngine(generator, multiplicator, formatter);

            var result = sut.GetPrimes(1);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void InitializeObject_NullPrimeNumberGenerator_ThrowArgumentNullException()
        {
            var builder = new PrimeNumberEngineBuilder().WithGenerator(null);

            Assert.Throws<ArgumentNullException>(() => { builder.Build(); });
        }

        [Test]
        public void InitializeObject_NullGridMultiplicator_ThrowArgumentNullException()
        {
            var builder = new PrimeNumberEngineBuilder().WithGridMultiplicator(null);

            Assert.Throws<ArgumentNullException>(() => { builder.Build(); });
        }

        [Test]
        public void InitializeObject_NullArrayFormatter_ThrowArgumentNullException()
        {
            var builder = new PrimeNumberEngineBuilder().WithFormatter(null);

            Assert.Throws<ArgumentNullException>(() => { builder.Build(); });
        }
    }
}