using System.Runtime.Serialization;
using NUnit.Framework;
using PrimeNumbers.Core;

namespace PrimeNumbers.UnitTests.PrimeNumbers.Core
{
    [TestFixture]
    public class GridFormatterTests
    {
        [Test]
        public void Formatt_TwoDimensionalArray_ReturnFormattedString()
        {
            var expected = "";
            var array = new int[,] { { -1, 2 }, { 2, 4 } };
            var sut = new GridFormatter();

            var result = sut.Formatt(array);
            
            Assert.AreEqual(expected, result);
        }
    }
}