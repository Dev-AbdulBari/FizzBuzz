using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthPartners.FizzBuzz.Domain.Interfaces
{
    public interface IProcessor
    {
        byte OrderConfig { get; }

        string? Process(int number);
    }
}
