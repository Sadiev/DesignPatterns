using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    //Context
    internal class Canvas
    {
        public Tool currentTool { get; set; }
        public void mouseDown()
        {
            currentTool.mouseDown();
        }
        public void mouseUp()
        {
            currentTool.mouseUp();
        }

    }
}
