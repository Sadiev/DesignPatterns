using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    internal class Button: UIControl
    {
        private Boolean isEnabled;
        public Button(DialogBox owner) : base(owner)
        {
        }

        public Boolean IsEnabled {
            get { return isEnabled; }
            set 
            {
                isEnabled = value;
                Owner.changed(this);
            } 
        }
    }
}
