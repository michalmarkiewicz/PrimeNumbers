using NUnit.Framework;
using PrimeNumbers.Core;
using PrimeNumbers.Core.NumberGenerators;
using PrimeNumbers.Tests.Common.Builders;

namespace PrimeNumbers.UnitTests.PrimeNumbers.Tests.Common
{
    [TestFixture]
    public class PrimeNumberGeneratorBuilderTests
    {
        [Test]
        public void Build_ReturnPrimeNumberGeneratorInstance()
        {
            var generator = new PrimeNumberGeneratorBuilder().Build();

            Assert.IsInstanceOf<PrimeGenerator>(generator);
        }
    }
}