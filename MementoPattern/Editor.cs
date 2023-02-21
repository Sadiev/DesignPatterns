using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    //Originator
    internal class Editor
    {
        public string Content { get; set; }
        public EditorState createState()
        { 
            return new EditorState(Content);
        }
        public void restore(EditorState state)
        {
            Content= state.Content;
        }
    }
}
