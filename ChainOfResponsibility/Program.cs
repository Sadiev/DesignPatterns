using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Authentication -> Logging -> Compression
            var compressor = new Compressor(null);
            var logger = new Logger(compressor);
            var authenticator = new Authenticator(logger);
            var server = new WebServer(authenticator);
            server.handle(new HttpRequest("admin", "1234"));

            Console.ReadLine();
        }
    }
}
