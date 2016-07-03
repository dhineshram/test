using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Power_of_a_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter the Power: ");
            int p = int.Parse(Console.ReadLine());
            Console.WriteLine("Result: " + Math.Pow(n, p));
            Console.ReadLine();
        }
    }
}
