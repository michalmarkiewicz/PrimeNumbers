using NUnit.Framework;
using PrimeNumbers.Core;
using PrimeNumbers.Tests.Common.Builders;

namespace PrimeNumbers.UnitTests.PrimeNumbers.Tests.Common
{
    [TestFixture]
    public class NumbersEngineBuilderTests
    {
        [Test]
        public void Build_ReturnNumberEngineInstance()
        {
            var result = new NumbersEngineBuilder().Build();

            Assert.IsInstanceOf<NumbersEngine>(result);
        }
    }
}