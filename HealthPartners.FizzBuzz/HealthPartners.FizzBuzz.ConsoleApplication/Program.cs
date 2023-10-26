using HealthPartners.FizzBuzz.ConsoleApplication.Services;

var inputValues = Enumerable.Range(1, 100).ToArray();

var processedValues = new RuntimeMasterProcessorService().ProcessAll(inputValues);

foreach (var processedValue in processedValues)
{
    Console.WriteLine(processedValue);
}