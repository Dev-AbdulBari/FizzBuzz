using HealthPartners.FizzBuzz.Domain.Interfaces;

namespace HealthPartners.FizzBuzz.Domain.Processors
{
    public class BuzzProcessor : IProcessor
    {
        public byte OrderConfig => 2;

        public string? Process(int number)
        {
            return IsNumberDivisbleByFive(number) ? "Buzz" : null;
        }

        private static bool IsNumberDivisbleByFive(int number)
        {
            return number % 5 == 0;
        }
    }
}
