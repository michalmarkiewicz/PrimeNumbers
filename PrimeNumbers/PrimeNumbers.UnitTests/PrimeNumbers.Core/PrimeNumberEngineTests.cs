using NSubstitute;
using NUnit.Framework;
using PrimeNumbers.Contracts;
using PrimeNumbers.Core;

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
    }
}