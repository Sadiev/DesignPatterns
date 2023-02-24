using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var task=new TransferMoneyTask();
            task.execute();

            var report=new GenerateReportTask();
            report.execute();

            Console.ReadKey();
        }
    }
}
