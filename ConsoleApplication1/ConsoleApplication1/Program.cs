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

            foreach (var a777 in args)
            {
                Console.WriteLine("Gena " + a777);
            }
            
            Console.ReadKey();
        }
    }
}
