using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    internal class AuditTrail
    {
        public void record()
        {
            Console.WriteLine("Audit");
        }
    }
}
