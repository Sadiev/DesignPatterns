using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    internal class BlackAndWhiteFilter : Filter
    {
        public void apply(string fileName)
        {
            Console.WriteLine("Applying Black and white filter");
        }
    }
}
