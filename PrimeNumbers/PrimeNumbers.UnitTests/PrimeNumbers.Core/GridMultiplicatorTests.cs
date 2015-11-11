using System.Collections.Generic;
using NUnit.Framework;
using PrimeNumbers.Core;

namespace PrimeNumbers.UnitTests.PrimeNumbers.Core
{
    [TestFixture]
    public class GridMultiplicatorTests
    {
        [Test]
        public void Calculate_MultiplyRowsWithCollumns_ReturnMultiArray()
        {
            var expected = new int[][] { new[] { 2, 3 }, new[] { 2, 4, 6 }, new[] { 3, 6, 9 } };
            var data = new List<int>() { 2, 3 };
            var sut = new GridMultiplicator();

            var result = sut.Calculate(data);

            CollectionAssert.AreEqual(expected, result);
        }
    }
}