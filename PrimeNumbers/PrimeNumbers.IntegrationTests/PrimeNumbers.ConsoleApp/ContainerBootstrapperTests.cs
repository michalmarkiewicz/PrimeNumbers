using System;
using Microsoft.Practices.Unity;
using NUnit.Framework;
using PrimeNumbers.ConsoleApp;
using PrimeNumbers.Contracts;
using PrimeNumbers.Core;

namespace PrimeNumbers.IntegrationTests.PrimeNumbers.ConsoleApp
{
    [TestFixture]
    public class ContainerBootstrapperTests
    {
        [Test]
        public void Configure_IArrayFormatter_RegisterTypes()
        {
            var sut = new UnityContainer();
            new ContainerBootstrapper().Configure(sut);

            var result = sut.Resolve<IArrayFormatter>();

            Assert.IsInstanceOf<GridFormatter>(result);
        }

        [Test]
        public void Configure_IGridMultiplicator_RegisterTypes()
        {
            var sut = new UnityContainer();
            new ContainerBootstrapper().Configure(sut);

            var result = sut.Resolve<IGridMultiplicator>();

            Assert.IsInstanceOf<GridMultiplicator>(result);
        }

        [Test]
        public void Configure_IPrimeNumberGenerator_RegisterTypes()
        {
            var sut = new UnityContainer();
            new ContainerBootstrapper().Configure(sut);

            var result = sut.Resolve<IPrimeNumberGenerator>();

            Assert.IsInstanceOf<PrimeNumberGenerator>(result);
        }

        [Test]
        public void Configure_PrimeNumberEngine_RegisterTypes()
        {
            var sut = new UnityContainer();
            new ContainerBootstrapper().Configure(sut);

            var result = sut.Resolve<IPrimeNumberEngine>();

            Assert.IsInstanceOf<PrimeNumberEngine>(result);
        }

        [Test]
        public void Configure_PrimeNumberEngine()
        {
            for (int i = 0; i < 1000; i++)
            {
                GetValue(i);
            }
        }

        private static void GetValue(int arg0)
        {
            Console.WriteLine(String.Format("{0} : {1}", arg0, (arg0 & 1) == 0));
        }
    }
}