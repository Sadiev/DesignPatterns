﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    internal class PngCompressor : Compressor
    {
        public void compress(string fileName)
        {
            Console.WriteLine("Compressing using PNG");
        }
    }
}
