using HealthPartners.FizzBuzz.Domain.Interfaces;

namespace HealthPartners.FizzBuzz.Domain.Processors
{
    public class FizzProcessor : IProcessor
    {
        public byte OrderConfig => 1;

        public string? Process(int number)
        {
            return IsDivisibleByThree(number) ? "Fizz" : null;
        }

        private static bool IsDivisibleByThree(int number)
        {
            return number % 3 == 0;
        }
    } 
}
