using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odd_or_Even
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(num / 2 == 0 ? "Even" : "Odd");
            Console.ReadLine();

        }
    }
}
