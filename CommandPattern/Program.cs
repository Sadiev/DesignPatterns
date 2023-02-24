using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var servoce=new CustomerService();
            var command =new AddCustomerCommand(servoce);
            var button = new Button(command);
            button.click();

            //Composite Commands
            var composite = new CompositeCommand();
            composite.add(new ResizeCommand());
            composite.add(new BlackAndWhiteCommand());
            composite.execute();
            Console.ReadKey();
        }
    }
}
