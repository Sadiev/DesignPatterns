using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    //Memento
    internal class EditorState
    {
        private readonly string content;

        public EditorState(string content)
        {
            this.content = content;
        }

        public string Content 
        {
            get { return content; }
        }
    }
}
