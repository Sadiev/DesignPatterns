using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    //Visitor
    internal interface Operation
    {
        //visit methods
        void apply(HeadingNode heading);
        void apply(AnchorNode anchor);
    }
}
