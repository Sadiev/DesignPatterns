﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    //Mediator
    internal abstract class DialogBox
    {
        public abstract void changed(UIControl control);
    }
}
