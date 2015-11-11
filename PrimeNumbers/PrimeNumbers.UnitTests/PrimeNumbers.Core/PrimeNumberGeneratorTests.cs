using NUnit.Framework;
using PrimeNumbers.Tests.Common.Builders;

namespace PrimeNumbers.UnitTests.PrimeNumbers.Core
{
    [TestFixture]
    public class PrimeNumberGeneratorTests
    {
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(41)]
        [TestCase(409)]
        [TestCase(691)]
        [TestCase(887)]
        [TestCase(533000389)]
        public void IsPrime_NumberIsPrime_ReturnTrue(int number)
        {
            var sut = new PrimeNumberGeneratorBuilder().Build();

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
            var sut = new PrimeNumberGeneratorBuilder().Build();

            var result = sut.IsPrime(number);

            Assert.False(result);
        }

        [Test]
        public void IsPrime_IntMax_DontThrowException()
        {
            var sut = new PrimeNumberGeneratorBuilder().Build();

            Assert.DoesNotThrow(() => sut.IsPrime(int.MaxValue));
        }

        [Test]
        public void IsPrime_IntMax_ReturnTrue()
        {
            var sut = new PrimeNumberGeneratorBuilder().Build();

            var result = sut.IsPrime(int.MaxValue);

            Assert.True(result);
        }

        [TestCase(-1)]
        [TestCase(-123423)]
        [TestCase(-13)]
        [TestCase(int.MinValue)]
        public void IsPrime_NegativeValue_ReturnFalse(int number)
        {
            var sut = new PrimeNumberGeneratorBuilder().Build();

            var result = sut.IsPrime(number);

            Assert.False(result);
        }

        [Test]
        public void Generate_StartingNumberIs0_ReturnFirstPrimeAfterZero()
        {
            var expected = new[] { 2 };
            var sut = new PrimeNumberGeneratorBuilder().Build();


            var result = sut.Generate(0);

            CollectionAssert.AreEqual(expected, result);
        }

        [Test]
        public void Generate_StartingNumberIs798_ReturnFirstPrimeAfterInputNumber()
        {
            var sut = new PrimeNumberGeneratorBuilder().Build();
            var expected = new[] { 809 };

            var result = sut.Generate(798);

            CollectionAssert.AreEqual(expected, result);
        }

        [Test]
        public void Generate_StartingNumberIs0_ReturnFirst5PrimesAfterZero()
        {
            var expected = new[] { 2, 3, 5, 7, 11 };
            var sut = new PrimeNumberGeneratorBuilder().WithPrimeNumbers(5).Build();

            var result = sut.Generate(0);

            CollectionAssert.AreEqual(expected, result);
        }

        [Test]
        public void Generate_StartingNumberIs_Return10PrimesAfterInputNumber()
        {
            var expected = new[] { 809, 811, 821, 823, 827, 829, 839, 853, 857, 859 };
            var sut = new PrimeNumberGeneratorBuilder().WithPrimeNumbers(10).Build();

            var result = sut.Generate(798);

            CollectionAssert.AreEqual(expected, result);
        }

        [Test]
        public void Generate_MaxIntValue_ReturnEmptyCollection()
        {
            var sut = new PrimeNumberGeneratorBuilder().WithPrimeNumbers(10).Build();

            var result = sut.Generate(int.MaxValue);

            CollectionAssert.IsEmpty(result);
        }

        [Test, MaxTime(1000)]
        public void Generate_MinIntValue_ReturnFirstThreePrimeNumber()
        {
            var expected = new[] { 2, 3, 5 };
            var sut = new PrimeNumberGeneratorBuilder().WithPrimeNumbers(3).Build();

            var result = sut.Generate(int.MinValue);

            CollectionAssert.AreEqual(expected, result);
        }

        [Test]
        public void Generate_NegativeValue_ReturnFirstPrime()
        {
            var expected = new[] { 2 };
            var sut = new PrimeNumberGeneratorBuilder().Build();

            var result = sut.Generate(-45);

            CollectionAssert.AreEqual(expected, result);
        }
    }
}