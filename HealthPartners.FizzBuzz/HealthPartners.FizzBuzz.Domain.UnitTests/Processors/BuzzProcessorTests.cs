using HealthPartners.FizzBuzz.Domain.Processors;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthPartners.FizzBuzz.Domain.UnitTests.Processors
{
    internal class BuzzProcessorTests
    {
        private BuzzProcessor _buzzProcessor;

        [SetUp]
        public void Setup()
        {
            _buzzProcessor = new BuzzProcessor();
        }

        [Test]
        public void ProcessMethod_WhenProvidedANumberDivisbleByFive_ReturnsBuzz()
        {
            var numberDivisbleByFive = 5;

            var result = _buzzProcessor.Process(numberDivisbleByFive);
            Assert.AreEqual("Buzz", result);
        }

        [Test]
        public void ProcessMethod_WhenProvidedANumberNotDivisbleByFive_ReturnsNull()
        {
            var numberNotDivisbleByFive = 6;

            var result = _buzzProcessor.Process(numberNotDivisbleByFive);
            Assert.AreEqual(null, result);
        }
    }
}
