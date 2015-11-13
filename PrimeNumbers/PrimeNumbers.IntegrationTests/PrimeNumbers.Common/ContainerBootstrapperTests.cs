using Microsoft.Practices.Unity;
using NUnit.Framework;
using PrimeNumbers.Common;
using PrimeNumbers.Contracts;
using PrimeNumbers.Core;
using PrimeNumbers.Core.NumberGenerators;

namespace PrimeNumbers.IntegrationTests.PrimeNumbers.Common
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

            var result = sut.Resolve<INumbersGenerator>(ConstantNames.PrimeGeneratorName);

            Assert.IsInstanceOf<PrimeGenerator>(result);
        }

        [Test]
        public void Configure_INumberGeneratorAndNameFibonacci_ReturnRegisteredType()
        {
            var sut = new UnityContainer();
            new ContainerBootstrapper().Configure(sut);

            var result = sut.Resolve<INumbersGenerator>(ConstantNames.FibonacciGeneratorName);

            Assert.IsInstanceOf<FibonacciGenerator>(result);
        }

        [Test]
        public void Configure_PrimeEngine_ReturnRegisteredType()
        {
            var sut = new UnityContainer();
            new ContainerBootstrapper().Configure(sut);

            var result = sut.Resolve<INumberEngine>(ConstantNames.PrimeEngineName);

            Assert.IsInstanceOf<NumbersEngine>(result);
        }

        [Test]
        public void Configure_FibonacciEngine_ReturnRegisteredType()
        {
            var sut = new UnityContainer();
            new ContainerBootstrapper().Configure(sut);

            var result = sut.Resolve<INumberEngine>(ConstantNames.FibonacciEngineName);

            Assert.IsInstanceOf<NumbersEngine>(result);
        }
    }
}