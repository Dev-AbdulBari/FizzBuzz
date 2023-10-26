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
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void ProcessMethod_WhenProvidedANumberDivisbleByFive_ReturnsBuzz()
        {
            var buzzProcessor = new BuzzProcessor();
            var numberDivisbleByFive = 5;

            var result = buzzProcessor.Process(numberDivisbleByFive);
            Assert.AreEqual("Buzz", result);
        }
    }
}
