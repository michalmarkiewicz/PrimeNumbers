using System;
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

        [TestCase(2)]
        [TestCase(3)]
        [TestCase(41)]
        [TestCase(409)]
        [TestCase(691)]
        [TestCase(887)]
        [TestCase(533000389)]
        public void IsPrime_NumberIsPrime_ReturnTrue(int number)
        {
            var result = sut.IsPrime(number);

            Assert.True(result);
        }

        [TestCase(4)]
        [TestCase(6)]
        [TestCase(222)]
        [TestCase(125)]
        [TestCase(678)]
        [TestCase(382754)]
        public void IsPrime_NumberIsNotPrime_ReturnFalse(int number)
        {
            var result = sut.IsPrime(number);

            Assert.False(result);
        }

        [Test]
        public void IsPrime_IntMax_DontThrowException()
        {
            Assert.DoesNotThrow(() => sut.IsPrime(int.MaxValue));
        }

        [Test]
        public void IsPrime_IntMax_ReturnTrue()
        {
            Console.WriteLine(int.MaxValue);
            var result = sut.IsPrime(int.MaxValue);

            Assert.True(result);
        }

        [TestCase(-1)]
        [TestCase(-123423)]
        [TestCase(-13)]
        [TestCase(int.MinValue)]
        public void IsPrime_NegativeValue_ReturnFalse(int number)
        {
            var result = sut.IsPrime(number);

            Assert.False(result);
        }
    }
}