using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var history=new BrowseHistory();
            history.push("a");
            history.push("b");
            history.push("c");

            var iterator=history.createIterator();
            while (iterator.hasNext())
            {
                var url=iterator.current();
                Console.WriteLine(url);
                iterator.next();
            }
            
            Console.ReadLine();
        }
    }
}
