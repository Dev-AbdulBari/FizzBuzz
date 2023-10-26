using HealthPartners.FizzBuzz.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthPartners.FizzBuzz.Domain.Processors
{
    public class BuzzProcessor : IProcessor
    {
        public byte OrderConfig => 2;

        public string? Process(int number)
        {
            return number % 5 == 0 ? "Buzz" : null;
        }
    }
}
