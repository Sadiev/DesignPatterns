using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    internal class Shape : IComponent
    {
        public void move()
        {
            Console.WriteLine("Move Shape");

        }

        public void render()
        {
            Console.WriteLine("Render Shape");
        }
    }
}
