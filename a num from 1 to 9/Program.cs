using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a_num_from_1_to_9
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("\nEnter the letter: ");
                int num = int.Parse(Console.ReadLine());
                if (num >= 1 && num <= 9)
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
