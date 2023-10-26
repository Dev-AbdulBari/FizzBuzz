using HealthPartners.FizzBuzz.ConsoleApplication.Interfaces;
using System.Reflection;

namespace HealthPartners.FizzBuzz.ConsoleApplication.Services
{
    public class RuntimeMasterProcessorService : IMasterProcessorService
    {
        public IEnumerable<string> ProcessAll(int[] numbers)
        {
            var projectName = @"HealthPartners.FizzBuzz\";
            var pathToDomainDllFilesFromSrcFolder = @"HealthPartners.FizzBuzz.Domain\bin\Debug\net6.0\HealthPartners.FizzBuzz.Domain.dll";
            var pathToProjectSrcFolder = Environment.CurrentDirectory.Substring(0, Environment.CurrentDirectory.IndexOf(projectName) + projectName.Length);

            var processedValues = new List<string>();
            IEnumerable<object> availableProcessors = DetectProcessors(pathToDomainDllFilesFromSrcFolder, pathToProjectSrcFolder);

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

        private static IEnumerable<object> DetectProcessors(string pathToDomainDllFilesFromSrcFolder, string pathToProjectSrcFolder)
        {
            return Assembly
                        .Load(File.ReadAllBytes(pathToProjectSrcFolder + pathToDomainDllFilesFromSrcFolder))
                        .GetTypes()
                        .Where(type => type.Name.Contains("Processor") && type.IsClass)
                        .Select(type => Activator.CreateInstance(type, null)!)
                        .OrderBy(instance => instance.GetType().GetProperty("OrderConfig")!.GetValue(instance))
                        .AsEnumerable();
        }
    }
}
