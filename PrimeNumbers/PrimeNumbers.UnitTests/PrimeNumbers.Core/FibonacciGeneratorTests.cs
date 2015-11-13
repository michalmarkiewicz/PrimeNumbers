using System.Collections.Generic;
using NUnit.Framework;
using PrimeNumbers.Core;
using PrimeNumbers.Core.NumberGenerators;

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
        
        [TestCase(4, new[] { 1, 1, 2, 3 })]
        [TestCase(9, new[] { 1, 1, 2, 3, 5, 8, 13, 21, 34 })]
        public void Generate_FourNumbersFromSequence_ReturnCollectionOfFibonacciNumbers(int number, int[] expected)
        {
            var result = sut.Generate(number);

            CollectionAssert.AreEqual(expected, result);
        }

        [TestCase(-1)]
        [TestCase(-111)]
        [TestCase(0)]
        [TestCase(int.MinValue)]
        public void Generate_InputNumberNegative_ReturnEmptyCollection(int number)
        {
            var result = sut.Generate(number);

            CollectionAssert.IsEmpty(result);
        }
    }
}