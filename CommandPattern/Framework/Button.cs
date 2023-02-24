using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    internal class Button
    {
        public string label { get; set; }
        private Command command;

        public Button(Command command)
        {
            this.command = command;
        }

        public void click() 
        { 
            command.execute();
        }
    }
}
