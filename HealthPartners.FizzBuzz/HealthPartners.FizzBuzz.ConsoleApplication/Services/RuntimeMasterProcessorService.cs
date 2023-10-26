using HealthPartners.FizzBuzz.ConsoleApplication.Interfaces;
using System.Reflection;

namespace HealthPartners.FizzBuzz.ConsoleApplication.Services
{
    public class RuntimeMasterProcessorService : IMasterProcessorService
    {
        private string _pathToProcessorDll;
        public RuntimeMasterProcessorService(string pathToProcessorDll)
        {
            _pathToProcessorDll = pathToProcessorDll;
        }

        public IEnumerable<string> ProcessAll(int[] numbers)
        {
            var processedValues = new List<string>();
            IEnumerable<object> availableProcessors = DetectProcessors();

            foreach (var number in numbers)
            {
                string? output = "";

                foreach (var processor in availableProcessors)
                {
                    var processMethod = processor.GetType().GetMethod("Process");

                    if (processMethod == null) continue;

                    var processorResult = (string?)processMethod.Invoke(processor, new object[] { number });

                    if (string.IsNullOrEmpty(output))
                    {
                        output = processorResult;
                    }
                    else
                    {
                        output += processorResult;
                    }
                }

                output ??= number.ToString();

                processedValues.Add(output);
            }

            return processedValues;
        }

        private IEnumerable<object> DetectProcessors()
        {
            return Assembly
                        .Load(File.ReadAllBytes(_pathToProcessorDll))
                        .GetTypes()
                        .Where(type => type.Name.Contains("Processor") && type.IsClass)
                        .Select(type => Activator.CreateInstance(type, null)!)
                        .OrderBy(instance => instance.GetType().GetProperty("OrderConfig")!.GetValue(instance))
                        .AsEnumerable();
        }
    }
}
