using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    //Observer
    internal interface EventHandler
    {
        //update
        void handle();
    }
}
