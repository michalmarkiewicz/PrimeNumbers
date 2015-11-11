using System.Collections.Generic;
using NUnit.Framework;
using PrimeNumbers.Core;

namespace PrimeNumbers.UnitTests.PrimeNumbers.Core
{
    [TestFixture]
    public class GridMultiplicatorTests
    {
        [Test]
        public void Calculate_TwoPrimesInCollection_MultiplyRowsWithCollumnsAndReturnMultiArray()
        {
            var expected = new[,] { { -1, 2, 3 }, { 2, 4, 6 }, { 3, 6, 9 } };
            var data = new List<int>() { 2, 3 };
            var sut = new GridMultiplicator();

            var result = sut.Calculate(data);

            CollectionAssert.AreEqual(expected, result);
        }

        [Test]
        public void Calculate_ThreePrimesInCollection_MultiplyRowsWithCollumnsAndReturnMultiArray()
        {
            var expected = new[,] { { -1, 3, 5, 7 }, { 3, 9, 15, 21 }, { 5, 15, 25, 35 }, { 7, 21, 35, 49 } };
            var data = new List<int>() { 3, 5, 7 };
            var sut = new GridMultiplicator();

            var result = sut.Calculate(data);

            CollectionAssert.AreEqual(expected, result);
        }
    }
}