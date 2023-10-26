using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthPartners.FizzBuzz.ConsoleApplication.Interfaces
{
    public interface IMasterProcessorService
    {
        IEnumerable<string> ProcessAll(int[] numbers);
    }
}
