using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace multiplication_table
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
                Console.WriteLine(i + " x " + n + " = " + i * n);
            Console.ReadLine();
        }
    }
}
