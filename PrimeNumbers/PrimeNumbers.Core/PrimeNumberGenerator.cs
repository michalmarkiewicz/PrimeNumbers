using System;
using System.Collections;
using System.Collections.Generic;

namespace PrimeNumbers.Core
{
    public class PrimeNumberGenerator
    {
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
            while (primes.Count < 1)
            {
                if (IsPrime(fromNumber))
                    primes.Add(fromNumber);

                fromNumber++;
            }

            return primes;
        }
    }
}