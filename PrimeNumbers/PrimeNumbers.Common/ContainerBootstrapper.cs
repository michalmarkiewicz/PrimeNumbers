using Microsoft.Practices.Unity;
using PrimeNumbers.Contracts;
using PrimeNumbers.Core;
using PrimeNumbers.Core.NumberGenerators;

namespace PrimeNumbers.Common
{
    public class ContainerBootstrapper
    {
        public void Configure(IUnityContainer container)
        {
            container.RegisterType<IArrayFormatter, GridFormatter>();
            container.RegisterType<IGridMultiplicator, GridMultiplicator>();
            container.RegisterType<INumbersGenerator, PrimeGenerator>(ConstantNames.PrimeGeneratorName, new InjectionConstructor(10));
            container.RegisterType<INumbersGenerator, FibonacciGenerator>(ConstantNames.FibonacciGeneratorName);

            // PRIME ENGINE
            container.RegisterType<INumberEngine, NumbersEngine>(ConstantNames.PrimeEngineName, new InjectionConstructor(
                                                                 new ResolvedParameter<INumbersGenerator>(ConstantNames.PrimeGeneratorName),
                                                                 new ResolvedParameter<IGridMultiplicator>(),
                                                                 new ResolvedParameter<IArrayFormatter>()));

            // FIBONACCI ENGINE
            container.RegisterType<INumberEngine, NumbersEngine>(ConstantNames.FibonacciEngineName, new InjectionConstructor(
                                                                 new ResolvedParameter<INumbersGenerator>(ConstantNames.FibonacciGeneratorName),
                                                                 new ResolvedParameter<IGridMultiplicator>(),
                                                                 new ResolvedParameter<IArrayFormatter>()));
        }
    }
}