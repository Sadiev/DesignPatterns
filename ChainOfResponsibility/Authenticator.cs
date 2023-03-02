using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    internal class Authenticator: Handler
    {
        public Authenticator(Handler next) : base(next)
        {
        }

        public override bool doHandle(HttpRequest request)
        {
            Console.WriteLine("Authentication");
            return !(request.Username == "admin" && request.Password == "1234");
        }
    }
}
