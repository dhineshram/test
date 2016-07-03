using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Even_num_betw_two_intervals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the limits: ");
            int l1 = int.Parse(Console.ReadLine());
            int l2 = int.Parse(Console.ReadLine());

            for (int i = l1; i <= l2; i++)
                if (i % 2 == 0)
                    Console.WriteLine(i);
            Console.ReadLine();
        }
    }
}
