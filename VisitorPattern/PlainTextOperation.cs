using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    internal class PlainTextOperation : Operation
    {
        public void apply(HeadingNode heading)
        {
            Console.WriteLine("text-heading");
        }

        public void apply(AnchorNode anchor)
        {
            Console.WriteLine("text-anchor");
        }
    }
}
