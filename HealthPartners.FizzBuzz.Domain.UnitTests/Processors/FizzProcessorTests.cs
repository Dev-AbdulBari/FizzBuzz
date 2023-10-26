using HealthPartners.FizzBuzz.Domain.Processors;
using NUnit.Framework;

namespace HealthPartners.FizzBuzz.Domain.UnitTests.Processors
{
    internal class FizzProcessorTests
    {
        private FizzProcessor _fizzProcessor;

        [SetUp]
        public void Setup()
        {
            _fizzProcessor = new FizzProcessor();
        }

        [Test]
        public void ProcessMethod_WhenProvidedANumberDivisbleByThree_ReturnsFizz()
        { 
            var numberDivisbleByThree = 3;

            var result = _fizzProcessor.Process(numberDivisbleByThree);
            Assert.AreEqual("Fizz", result);
        }

        [Test]
        public void ProcessMethod_WhenProvidedANumberNotDivisbleByThree_ReturnsNull()
        {
            var numberNotDivisbleByThree = 4;

            var result = _fizzProcessor.Process(numberNotDivisbleByThree);
            Assert.IsNull(result);
        }
    }
}
