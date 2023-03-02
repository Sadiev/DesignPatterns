using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    internal class TextBox: UIControl
    {
        private string content;
        public TextBox(DialogBox owner) : base(owner)
        {
        }

        public string Content 
        {
            get { return content; }
            set 
            { 
                content = value;
                Owner.changed(this);
            } 
        }
    }
}
