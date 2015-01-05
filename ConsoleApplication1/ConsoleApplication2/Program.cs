using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            var driver = new FirefoxDriver();
            driver.Url = "http://google.com";
            Console.ReadKey();
            driver.Close();
        }
    }
}
