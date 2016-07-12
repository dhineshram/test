using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sum_of_n_using_for_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the N: ");
            int n = int.Parse(Console.ReadLine()),sum=0;
            for(;n>0;n--)
                sum += n;
            Console.WriteLine("Sum is " + sum);
            Console.ReadLine();
        }
    }
}
