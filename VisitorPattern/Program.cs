using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var doc=new HtmlDocument();
            doc.add(new HeadingNode());
            doc.add(new AnchorNode());
            Console.WriteLine("HighlightOperation");
            doc.execute(new HighlightOperation());

            Console.WriteLine("\nPlainTextOperation");
            doc.execute(new PlainTextOperation());

            Console.ReadLine();
        }
    }
}
