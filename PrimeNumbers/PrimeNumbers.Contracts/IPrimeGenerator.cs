namespace PrimeNumbers.Contracts
{
    public interface IPrimeGenerator : INumbersGenerator
    {
        bool IsPrime(int number);
    }
}