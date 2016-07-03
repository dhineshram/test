using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prime_num_betw_two_interval
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the limits: ");
            int l1 = int.Parse(Console.ReadLine());
            int l2 = int.Parse(Console.ReadLine()), j;

            for (int i = l1; i < l2; i++)
            {
                for (j = 2; j < i; j++)
                {
                    if (i % j == 0)
                        break;
                    if (j == (i - 1))
                        Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}
