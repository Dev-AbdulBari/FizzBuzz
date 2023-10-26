namespace HealthPartners.FizzBuzz.ConsoleApplication.Interfaces
{
    public interface IMasterProcessorService
    {
        IEnumerable<string> ProcessAll(int[] numbers);
    }
}
