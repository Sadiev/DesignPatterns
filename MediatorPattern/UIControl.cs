using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    internal class UIControl
    {
        protected DialogBox Owner;

        public UIControl(DialogBox owner)
        {
            Owner = owner;
        }
    }
}
