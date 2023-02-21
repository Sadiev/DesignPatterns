using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    //Caretaker
    internal class History
    {
        private List<EditorState> states= new List<EditorState>();
        public void push(EditorState state)
        { 
            states.Add(state);
        }
        public EditorState pop()
        {
            var lastIndex=states.Count-1;
            var lastState = states[lastIndex];
            states.RemoveAt(lastIndex);
            return lastState;
        }
    }
}
