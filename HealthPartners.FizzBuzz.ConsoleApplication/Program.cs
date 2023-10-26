using HealthPartners.FizzBuzz.ConsoleApplication.Services;

var inputValues = Enumerable.Range(1, 100).ToArray();

var projectName = @"FizzBuzz\";
var pathToDomainDllFilesFromSrcFolder = @"HealthPartners.FizzBuzz.Domain\bin\Debug\net6.0\HealthPartners.FizzBuzz.Domain.dll";
var pathToProjectSrcFolder = Environment.CurrentDirectory.Substring(0, Environment.CurrentDirectory.IndexOf(projectName) + projectName.Length);


var processedValues = new RuntimeMasterProcessorService(pathToProjectSrcFolder + pathToDomainDllFilesFromSrcFolder).ProcessAll(inputValues);

foreach (var processedValue in processedValues)
{
    Console.WriteLine(processedValue);
}