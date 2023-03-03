using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    internal class HeadingNode : HtmlNode
    {
        public void execute(Operation operation)
        {
            operation.apply(this);
        }
    }
}
