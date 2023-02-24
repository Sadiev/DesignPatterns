using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var imageStorage=new ImageStorage();
            imageStorage.store("a", new JpegCompressor(), new BlackAndWhiteFilter());
            imageStorage.store("a", new PngCompressor(), new BlackAndWhiteFilter());

            Console.ReadLine();
        }
    }
}
