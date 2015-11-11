using NUnit.Framework;
using PrimeNumbers.Core;

namespace PrimeNumbers.UnitTests.PrimeNumbers.Core
{
    [TestFixture]
    public class PrimeNumberGeneratorTests
    {
        private PrimeNumberGenerator sut;

        [SetUp]
        public void SetUp()
        {
            sut = new PrimeNumberGenerator();
        }

        [Test]
        public void IsPrime_NumberIsPrime_ReturnTrue()
        {
            var result = sut.IsPrime(2);

            Assert.True(result);
        }

        [Test]
        public void IsPrime_NumberIsNotPrime_ReturnFalse()
        {
            var result = sut.IsPrime(4);

            Assert.IsFalse(result);
        }
    }
}