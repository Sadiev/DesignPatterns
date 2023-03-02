﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    internal class WebServer
    {
        private  Handler handler;

        public WebServer(Handler handler)
        {
            this.handler = handler;
        }

        public void handle(HttpRequest request)
        {
            handler.handle(request);
        }
    }
}
