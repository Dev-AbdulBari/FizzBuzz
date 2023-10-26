using HealthPartners.FizzBuzz.Domain.Processors;
using NUnit.Framework;

namespace HealthPartners.FizzBuzz.Domain.UnitTests.Processors
{
    internal class FizzProcessorTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ProcessMethod_WhenProvidedANumberDivisbleByThree_ReturnsFizz()
        {
            var fizzProcessor = new FizzProcessor();
            var numberDivisbleByThree = 3;

            var result = fizzProcessor.Process(numberDivisbleByThree);
            Assert.AreEqual("Fizz", result);
        }
    }
}
