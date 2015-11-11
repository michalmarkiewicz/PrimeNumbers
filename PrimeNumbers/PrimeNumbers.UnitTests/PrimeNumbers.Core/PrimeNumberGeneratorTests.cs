using NUnit.Framework;
using PrimeNumbers.Core;

namespace PrimeNumbers.UnitTests.PrimeNumbers.Core
{
    [TestFixture]
    public class PrimeNumberGeneratorTests
    {
        [Test]
        public void IsPrime_NumberIsPrime_ReturnTrue()
        {
            var sut = new PrimeNumberGenerator();

            var result = sut.IsPrime(2);

            Assert.True(result);
        }
    }
}