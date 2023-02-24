using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    internal class ResizeCommand : Command
    {
        public void execute()
        {
            Console.WriteLine("Resize");
        }
    }
}
