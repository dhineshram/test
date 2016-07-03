using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number: ");
            int n = int.Parse(Console.ReadLine());
            int output = 1;
            while(n!=0)
            {
                output *= n;
                n--;
            }
            Console.WriteLine(output);
            Console.ReadLine();
        }
    }
}
