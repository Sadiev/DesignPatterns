using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MementoPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var editor = new Editor();
            var history = new History();

            editor.Content = "a";
            history.push(editor.createState());

            editor.Content = "b";
            history.push(editor.createState());

            editor.Content = "c";
            editor.restore(history.pop());

            Console.WriteLine(editor.Content);
            Console.ReadLine();
        }
    }
}
