using System;
using Microsoft.Practices.Unity;
using NUnit.Framework;
using PrimeNumbers.ConsoleApp;
using PrimeNumbers.Contracts;
using PrimeNumbers.Core;
using PrimeNumbers.Core.NumberGenerators;

namespace PrimeNumbers.IntegrationTests.PrimeNumbers.ConsoleApp
{
    [TestFixture]
    public class ContainerBootstrapperTests
    {
        [Test]
        public void Configure_IArrayFormatter_ReturnRegisteredType()
        {
            var sut = new UnityContainer();
            new ContainerBootstrapper().Configure(sut);

            var result = sut.Resolve<IArrayFormatter>();

            Assert.IsInstanceOf<GridFormatter>(result);
        }

        [Test]
        public void Configure_IGridMultiplicator_ReturnRegisteredType()
        {
            var sut = new UnityContainer();
            new ContainerBootstrapper().Configure(sut);

            var result = sut.Resolve<IGridMultiplicator>();

            Assert.IsInstanceOf<GridMultiplicator>(result);
        }

        [Test]
        public void Configure_INumberGeneratorAndNamePrime_ReturnRegisteredType()
        {
            var sut = new UnityContainer();
            new ContainerBootstrapper().Configure(sut);

            var result = sut.Resolve<INumbersGenerator>(NameConstant.PrimeGeneratorName);

            Assert.IsInstanceOf<PrimeGenerator>(result);
        }

        [Test]
        public void Configure_PrimeNumberEngine_ReturnRegisteredType()
        {
            var sut = new UnityContainer();
            new ContainerBootstrapper().Configure(sut);

            var result = sut.Resolve<IPrimeNumberEngine>();

            Assert.IsInstanceOf<NumbersEngine>(result);
        }

        [Test]
        public void Configure_INumberGeneratorAndNameFibonacci_ReturnRegisteredType()
        {
            var sut = new UnityContainer();
            new ContainerBootstrapper().Configure(sut);

            var result = sut.Resolve<INumbersGenerator>(NameConstant.FibonacciGeneratorName);

            Assert.IsInstanceOf<FibonacciGenerator>(result);
        }
    }
}