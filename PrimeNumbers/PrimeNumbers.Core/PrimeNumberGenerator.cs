using System;

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
    }
}