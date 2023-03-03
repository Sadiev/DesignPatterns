using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    internal class HighlightOperation : Operation
    {
        public void apply(HeadingNode heading)
        {
            Console.WriteLine("highlight-heading");
        }

        public void apply(AnchorNode anchor)
        {
            Console.WriteLine("highlight-anchor");
        }
    }
}
