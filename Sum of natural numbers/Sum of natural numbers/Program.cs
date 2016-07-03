using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sum_of_natural_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter limit: ");
            int lim = int.Parse(Console.ReadLine()), output = 0;
            while (lim != 0)
                output += lim--;
            Console.WriteLine("Sum is " + output);
            Console.ReadLine();
        }
    }
}
