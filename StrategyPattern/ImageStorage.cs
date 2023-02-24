using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    internal class ImageStorage
    {
        public void store(string fileName, Compressor compressor, Filter filter)
        {
            compressor.compress(fileName);
            filter.apply(fileName);
        }
    }
}
