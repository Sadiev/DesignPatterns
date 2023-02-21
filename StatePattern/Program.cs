using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var canvas = new Canvas();
            canvas.currentTool=new SelectionTool();
            canvas.mouseDown();
            canvas.mouseUp();

            Console.ReadLine();
        }
    }
}
