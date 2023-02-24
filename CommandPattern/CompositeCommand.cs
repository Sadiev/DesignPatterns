using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    internal class CompositeCommand : Command
    {
        private List<Command> commands=new List<Command>();
        public void add(Command command)
        {
            commands.Add(command);
        }
        public void execute()
        {
            foreach (Command command in commands)
            {
                command.execute();
            }
        }
    }
}
