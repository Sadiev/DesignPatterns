using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    internal interface Iterator
    {
        bool hasNext();
        string current();
        void next();
    }
}
