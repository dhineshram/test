using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Count_digits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the integer: ");
            int integer = int.Parse(Console.ReadLine()),count=0;
            while(integer!=0)
            {
                integer /= 10;
                count++;
            }
            Console.WriteLine("Total number of digits: " + count);
            Console.ReadLine();
        }
    }
}
