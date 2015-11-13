using System;
using NSubstitute;
using NUnit.Framework;
using PrimeNumbers.Contracts;
using PrimeNumbers.Tests.Common.Builders;

namespace PrimeNumbers.UnitTests.PrimeNumbers.Core
{
    [TestFixture]
    public class NumberEngineTests
    {
        private IArrayFormatter formatter;

        [SetUp]
        public void Setup()
        {
            formatter = Substitute.For<IArrayFormatter>();
        }

        [Test]
        public void GetNumbers_ReadStringValue_GenerateOnePrimesAndFormattGridToString()
        {
            var expected = " \t2\r\n2\t4";
            formatter.Formatt(null).ReturnsForAnyArgs(x => expected);
            var sut = new NumbersEngineBuilder().WithFormatter(formatter).Build();

            var result = sut.GetNumbers(1);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void InitializeObject_NullPrimeNumberGenerator_ThrowArgumentNullException()
        {
            var builder = new NumbersEngineBuilder().WithGenerator(null);

            Assert.Throws<ArgumentNullException>(() => { builder.Build(); });
        }

        [Test]
        public void InitializeObject_NullGridMultiplicator_ThrowArgumentNullException()
        {
            var builder = new NumbersEngineBuilder().WithGridMultiplicator(null);

            Assert.Throws<ArgumentNullException>(() => { builder.Build(); });
        }

        [Test]
        public void InitializeObject_NullArrayFormatter_ThrowArgumentNullException()
        {
            var builder = new NumbersEngineBuilder().WithFormatter(null);

            Assert.Throws<ArgumentNullException>(() => { builder.Build(); });
        }
    }
}