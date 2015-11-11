using NUnit.Framework;
using PrimeNumbers.Core;
using PrimeNumbers.Tests.Common.Builders;

namespace PrimeNumbers.UnitTests.PrimeNumbers.Tests.Common
{
    [TestFixture]
    public class PrimeNumberGeneratorBuilderTests
    {
        [Test]
        public void Build_ReturnInstanceOfPrimeNumberGenerator()
        {
            var generator = new PrimeNumberGeneratorBuilder().Build();

            Assert.IsInstanceOf<PrimeNumberGenerator>(generator);
        }
    }
}