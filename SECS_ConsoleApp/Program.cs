using System;
using ConsoleLibrary;

namespace SECS_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Utilities utilities = new Utilities();
            string stringHello = "Hello World";
            utilities.WriteLine(stringHello);
            Console.ReadKey();
        }
    }
}
