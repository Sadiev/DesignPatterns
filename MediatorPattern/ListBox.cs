using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    internal class ListBox: UIControl
    {
        private string selection;
        public ListBox(DialogBox owner) : base(owner)
        {
        }

        public string Selection { 
            get { return selection; } 
            set 
            { 
                selection = value;
                Owner.changed(this);
            } 
        }
    }
}
