using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    internal class HttpRequest
    {
        public string Username { get; }
        public string Password { get; }

        public HttpRequest(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}
