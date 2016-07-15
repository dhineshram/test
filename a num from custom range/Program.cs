using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a_num_from_custom_range
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the range: ");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            while (true)
            {
                Console.Write("\nEnter the letter: ");
                int num = int.Parse(Console.ReadLine());
                if (num >= n1 && num <= n2)
                {
                    Console.WriteLine(num);
                    break;
                }
                else
                    Console.WriteLine("your entered number is not in the range");
            }
            Console.ReadLine();
        }
    }
}
