namespace PrimeNumbers.Core
{
    public class PrimeNumberGenerator
    {
        public bool IsPrime(int number)
        {
            if ((number & 1) == 0)
            {
                if (number == 2)
                    return true;

                return false;
            }

            for (int i = 3; (i * i) <= number; i += 2)
            {
                if ((number % i) == 0)
                {
                    return false;
                }
            }

            return number != 1;
        }
    }
}