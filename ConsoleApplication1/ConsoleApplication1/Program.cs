using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number: ");
            int num = int.Parse(Console.ReadLine());
            if (num > 0)
                Console.WriteLine("Positive");
            else if (num < 0)
                Console.WriteLine("Negative");
            else
                Console.WriteLine("Zero");
            Console.ReadLine();
        }
    }
}
