using System.Collections.Generic;
using NUnit.Framework;
using PrimeNumbers.Core;

namespace PrimeNumbers.UnitTests.PrimeNumbers.Core
{
    [TestFixture]
    public class FibonacciGeneratorTests
    {
        private FibonacciGenerator sut;

        [SetUp]
        public void Setup()
        {
            sut = new FibonacciGenerator();
        }

        [Test]
        public void Generate_FristNumberFromSequence_ReturnOne()
        {
            var expected = new int[] { 1 };

            var result = sut.Generate(1);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Generate_TwoNumbersFromSequence_ReturnCollectionOfFibonacciNumbers()
        {
            var expected = new List<int>() { 1, 1 };

            var result = sut.Generate(2);

            CollectionAssert.AreEqual(expected, result);
        }
        
        [TestCase(4, new int[] { 1, 1, 2, 3 })]
        [TestCase(9, new int[] { 1, 1, 2, 3, 5, 8, 13, 21, 34 })]
        public void Generate_FourNumbersFromSequence_ReturnCollectionOfFibonacciNumbers(int number, int[] expected)
        {
            var result = sut.Generate(number);

            CollectionAssert.AreEqual(expected, result);
        }
    }
}