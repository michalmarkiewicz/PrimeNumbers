﻿using NUnit.Framework;
using PrimeNumbers.Core;
using PrimeNumbers.Core.NumberGenerators;
using PrimeNumbers.Tests.Common.Builders;

namespace PrimeNumbers.IntegrationTests.PrimeNumbers.Core
{
    [TestFixture]
    public class NumberEngineTests
    {
        [Test]
        public void GetNumbers_OnePrimeFromNumberTwo_GenerateOnePrimesAndFormattGridToString()
        {
            var numberOfPrimesToGet = 1;
            var expected = " \t2\r\n2\t4";
            var sut = new NumbersEngineBuilder().WithGenerator(new PrimeGenerator(numberOfPrimesToGet))
                                                    .WithGridMultiplicator(new GridMultiplicator())
                                                    .WithFormatter(new GridFormatter())
                                                    .Build();

            var result = sut.GetNumbers(2);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void GetNumbers_TwoPrimesFromNumberTwo_GenerateOnePrimesAndFormattGridToString()
        {
            var numberOfPrimesToGet = 2;
            var expected = " \t2\t3\r\n2\t4\t6\r\n3\t6\t9";
            var sut = new NumbersEngineBuilder().WithGenerator(new PrimeGenerator(numberOfPrimesToGet))
                                                    .WithGridMultiplicator(new GridMultiplicator())
                                                    .WithFormatter(new GridFormatter())
                                                    .Build();

            var result = sut.GetNumbers(2);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void GetNumbers_OneNumberFromFibonacciSequence_GenerateFibonacciSequenceAndFormattGridToString()
        {
            var expected = " \t1\r\n1\t1";
            var sut = new NumbersEngineBuilder().WithGenerator(new FibonacciGenerator())
                                                    .WithGridMultiplicator(new GridMultiplicator())
                                                    .WithFormatter(new GridFormatter())
                                                    .Build();

            var result = sut.GetNumbers(1);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void GetNumbers_ThreeNumbersFromFibonacciSequence_GenerateFibonacciSequenceAndFormattGridToString()
        {
            var expected = " \t1\t1\t2\r\n1\t1\t1\t2\r\n1\t1\t1\t2\r\n2\t2\t2\t4";
            var sut = new NumbersEngineBuilder().WithGenerator(new FibonacciGenerator())
                                                    .WithGridMultiplicator(new GridMultiplicator())
                                                    .WithFormatter(new GridFormatter())
                                                    .Build();

            var result = sut.GetNumbers(3);

            Assert.AreEqual(expected, result);
        }
    }
}