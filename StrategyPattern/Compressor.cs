using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    internal interface Compressor
    {
        //byte[] compress(byte[] image);
        void compress(string fileName);
    }
}
