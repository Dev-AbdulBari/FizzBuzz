namespace HealthPartners.FizzBuzz.Domain.Interfaces
{
    public interface IProcessor
    {
        byte OrderConfig { get; }

        string? Process(int number);
    }
}
