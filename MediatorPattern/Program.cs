using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dialog=new ArticlesDialogBox();
            dialog.simulateUserInteraction();

            Console.ReadKey();
        }
    }
}
