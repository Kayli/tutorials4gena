using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Gena!");

            foreach (var argument in args)
            {
                Console.WriteLine("Argument " + argument);
            }
            
            Console.ReadKey();
        }
    }
}
