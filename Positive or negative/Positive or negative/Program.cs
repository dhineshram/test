using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Positive_or_negative
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(num != 0 ? (num > 0 ? "Positive" : "Negative") : "Zero");
            Console.ReadLine();
        }
    }
}
