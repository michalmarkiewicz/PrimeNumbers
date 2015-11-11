using NUnit.Framework;
using PrimeNumbers.Core;
using PrimeNumbers.Tests.Common.Builders;

namespace PrimeNumbers.UnitTests.PrimeNumbers.Tests.Common
{
    [TestFixture]
    public class PrimeNumberEngineBuilderTests
    {
        [Test]
        public void Build_ReturnPrimeNumberEngineInstance()
        {
            var result = new PrimeNumberEngineBuilder().Build();

            Assert.IsInstanceOf<PrimeNumberEngine>(result);
        }
    }
}