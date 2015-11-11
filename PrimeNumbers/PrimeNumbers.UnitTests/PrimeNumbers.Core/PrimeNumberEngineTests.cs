using System;
using NSubstitute;
using NUnit.Framework;
using PrimeNumbers.Contracts;
using PrimeNumbers.Tests.Common.Builders;

namespace PrimeNumbers.UnitTests.PrimeNumbers.Core
{
    [TestFixture]
    public class PrimeNumberEngineTests
    {
        private IArrayFormatter formatter;

        [SetUp]
        public void Setup()
        {
            formatter = Substitute.For<IArrayFormatter>();
        }

        [Test]
        public void GetPrimes_ReadStringValue_GenerateOnePrimesAndFormattGridToString()
        {
            var expected = " \t2\r\n2\t4";
            formatter.Formatt(null).ReturnsForAnyArgs(x => expected);
            var sut = new PrimeNumberEngineBuilder().WithFormatter(formatter).Build();

            var result = sut.GetPrimes("1");

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