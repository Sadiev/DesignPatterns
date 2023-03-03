using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    internal interface HtmlNode
    {
        void execute(Operation operation);
    }
}
