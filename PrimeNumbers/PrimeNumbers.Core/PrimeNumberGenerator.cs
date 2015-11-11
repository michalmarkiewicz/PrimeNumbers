using System;
using System.Collections;
using System.Collections.Generic;

namespace PrimeNumbers.Core
{
    public class PrimeNumberGenerator
    {
        private readonly int numberOfPrimesToGet;

        public PrimeNumberGenerator(int numberOfPrimesToGet)
        {
            this.numberOfPrimesToGet = numberOfPrimesToGet;
        }

        public bool IsPrime(int number)
        {
            if (number == 2 || number == int.MaxValue)
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

            while (primes.Count < numberOfPrimesToGet)
            {
                if (IsPrime(fromNumber))
                    primes.Add(fromNumber);

                fromNumber++;
            }

            return primes;
        }
    }
}