using Microsoft.Practices.Unity;
using PrimeNumbers.Contracts;
using PrimeNumbers.Core;

namespace PrimeNumbers.ConsoleApp
{
    public class ContainerBootstrapper
    {
        public void Configure(IUnityContainer container)
        {
            container.RegisterType<IArrayFormatter, GridFormatter>();
            container.RegisterType<IGridMultiplicator, GridMultiplicator>();
            container.RegisterType<IPrimeNumberGenerator, PrimeNumberGenerator>(new InjectionConstructor(10));
            container.RegisterType<IPrimeNumberEngine, PrimeNumberEngine>();
        }
    }
}