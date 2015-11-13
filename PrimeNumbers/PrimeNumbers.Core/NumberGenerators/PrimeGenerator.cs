using System;
using System.Collections.Generic;
using PrimeNumbers.Contracts;

namespace PrimeNumbers.Core.NumberGenerators
{
    public class PrimeGenerator : IPrimeGenerator
    {
        private readonly int numberOfPrimesToGet;

        public PrimeGenerator(int numberOfPrimesToGet)
        {
            if (numberOfPrimesToGet < 1)
                throw new ArgumentException("Value numberOfPrimesToGet have to be greater than 0.");

            this.numberOfPrimesToGet = numberOfPrimesToGet;
        }

        public bool IsPrime(int number)
        {
            if (number == 2 || CheckIfMaxInt(number))
                return true;

            if (number < 0 || (number & 1) == 0)
                return false;

            for (int i = 3; (i * i) <= number; i += 2)
                if ((number % i) == 0)
                    return false;
            
            return number != 1;
         }

        public IEnumerable<int> Generate(int fromNumber)
        {
            var primes = new List<int>();

            if (CheckIfMaxInt(fromNumber))
                return primes;

            if (CheckIfNegativeValue(fromNumber))
                fromNumber = 0;

            while (primes.Count < numberOfPrimesToGet)
            {
                if (IsPrime(fromNumber))
                    primes.Add(fromNumber);

                fromNumber++;
            }

            return primes;
        }

        private bool CheckIfNegativeValue(int fromNumber)
        {
            return fromNumber < 0;
        }

        private bool CheckIfMaxInt(int fromNumber)
        {
            return fromNumber == int.MaxValue;
        }
    }
}