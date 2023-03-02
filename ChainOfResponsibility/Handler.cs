﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    internal abstract class Handler
    {
        private Handler next;

        protected Handler(Handler next)
        {
            this.next = next;
        }

        public void handle(HttpRequest request)
        {
            if (doHandle(request))
                return;
            if (next != null)
            {
                next.handle(request);
            }
        }

        public abstract bool doHandle(HttpRequest request);
    }
}
