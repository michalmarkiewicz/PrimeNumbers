using System;
using Microsoft.Practices.Unity;
using PrimeNumbers.Contracts;

namespace PrimeNumbers.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new UnityContainer();
            new ContainerBootstrapper().Configure(container);

            var engine = container.Resolve<IPrimeNumberEngine>();

            Console.WriteLine("---- Prime Numbers Generator ----");
            Console.WriteLine("To exit type 'exit'");
            
            while (true)
            {
                try
                {
                    Console.WriteLine("Specify a number after which primes should be generated: ");
                    var input = Console.ReadLine();

                    if (input.ToLower() == "exit")
                        break;

                    var number = ConvertInput(input);
                    var result = engine.GetNumbers(number);

                    Console.WriteLine(result);
                    Console.WriteLine();
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    Console.WriteLine("Press any key to try again");
                    Console.WriteLine();
                    Console.ReadKey();
                }
            }
        }

        private static int ConvertInput(string input)
        {
            try
            {
                return int.Parse(input);
            }
            catch (Exception ex)
            {
                throw new ArgumentException(string.Format("Couldn't parse input value to int. Value: {0}", input));
            }
        }
    }
}
