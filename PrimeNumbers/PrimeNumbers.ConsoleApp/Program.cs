using Microsoft.Practices.Unity;

namespace PrimeNumbers.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new UnityContainer();
            new ContainerBootstrapper().Configure(container);

            
        }
    }
}
