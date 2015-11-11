using System;
using System.Runtime.Serialization;
using NUnit.Framework;
using PrimeNumbers.Core;

namespace PrimeNumbers.UnitTests.PrimeNumbers.Core
{
    [TestFixture]
    public class GridFormatterTests
    {
        [Test]
        public void Formatt_TwoDimensionalArrayWithTwoElements_ReturnFormattedString()
        {
            var expected = " \t2\r\n2\t4";
            var array = new int[,] { { -1, 2 }, { 2, 4 } };
            var sut = new GridFormatter();

            var result = sut.Formatt(array);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Formatt_TwoDimensionalArrayWithThreElements_ReturnFormattedString()
        {
            var expected = " \t2\t3\r\n2\t4\t6\r\n3\t6\t9";
            var array = new int[,] { { -1, 2, 3 }, { 2, 4, 6 }, {3, 6, 9} };
            var sut = new GridFormatter();

            var result = sut.Formatt(array);

            Assert.AreEqual(expected, result);
        }
    }
}