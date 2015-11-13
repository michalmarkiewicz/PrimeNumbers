﻿using Microsoft.Practices.Unity;
using PrimeNumbers.Contracts;
using PrimeNumbers.Core;
using PrimeNumbers.Core.NumberGenerators;

namespace PrimeNumbers.ConsoleApp
{
    public class ContainerBootstrapper
    {
        public void Configure(IUnityContainer container)
        {
            container.RegisterType<IArrayFormatter, GridFormatter>();
            container.RegisterType<IGridMultiplicator, GridMultiplicator>();
            container.RegisterType<INumbersGenerator, PrimeGenerator>(NameConstant.PrimeGeneratorName, new InjectionConstructor(10));
            container.RegisterType<INumbersGenerator, FibonacciGenerator>(NameConstant.FibonacciGeneratorName);
            container.RegisterType<IPrimeNumberEngine, NumbersEngine>(new InjectionConstructor(
                                                                          new ResolvedParameter<INumbersGenerator>(NameConstant.PrimeGeneratorName),
                                                                          new ResolvedParameter<IGridMultiplicator>(),
                                                                          new ResolvedParameter<IArrayFormatter>()));
        }
    }
}