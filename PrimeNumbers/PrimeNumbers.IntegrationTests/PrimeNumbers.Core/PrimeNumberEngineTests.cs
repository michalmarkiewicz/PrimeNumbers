using NUnit.Framework;
using PrimeNumbers.Core;
using PrimeNumbers.Tests.Common.Builders;

namespace PrimeNumbers.IntegrationTests.PrimeNumbers.Core
{
    [TestFixture]
    public class PrimeNumberEngineTests
    {
        [Test]
        public void GetPrimes_OnePrimeFromNumberTwo_GenerateOnePrimesAndFormattGridToString()
        {
            var numberOfPrimesToGet = 1;
            var expected = " \t2\r\n2\t4";
            var sut = new PrimeNumberEngineBuilder().WithGenerator(new PrimeNumberGenerator(numberOfPrimesToGet))
                                                    .WithGridMultiplicator(new GridMultiplicator())
                                                    .WithFormatter(new GridFormatter())
                                                    .Build();

            var result = sut.GetPrimes(2);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void GetPrimes_TwoPrimesFromNumberTwo_GenerateOnePrimesAndFormattGridToString()
        {
            var numberOfPrimesToGet = 2;
            var expected = " \t2\t3\r\n2\t4\t6\r\n3\t6\t9";
            var sut = new PrimeNumberEngineBuilder().WithGenerator(new PrimeNumberGenerator(numberOfPrimesToGet))
                                                    .WithGridMultiplicator(new GridMultiplicator())
                                                    .WithFormatter(new GridFormatter())
                                                    .Build();

            var result = sut.GetPrimes(2);

            Assert.AreEqual(expected, result);
        }
    }
}