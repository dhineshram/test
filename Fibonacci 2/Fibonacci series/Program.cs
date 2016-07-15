using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fibonacci_series
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number: ");
            int n = int.Parse(Console.ReadLine());
            int a = 0, b = 1, i = 0;
            Console.WriteLine("0\n1");
            for (; i < n;)
            {
                i = a + b; 
                a = b;
                b = i;
                if (i<n)
                    Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
