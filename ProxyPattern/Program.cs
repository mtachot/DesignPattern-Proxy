using ProxyPattern.Classes;
using ProxyPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    class Program
    {
        public static void Main(string[] args)
        {
            IImage image = new ProxyImage("test_10Mo.jpg");

            // Image will be loaded from disk
            image.Display();
            Console.WriteLine("\n");

            // Image will not be loaded from disk
            image.Display();
            Console.ReadLine();
        }
    }
}
