using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    //ConreteState B
    internal class BrashTool : Tool
    {
        public void mouseDown()
        {
            Console.WriteLine("Brash icon");
        }

        public void mouseUp()
        {
            Console.WriteLine("Draw a line");
        }
    }
}
