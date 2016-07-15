using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biggest_of_10_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int loop = 0, big = 0, temp = 0;
            while(loop++ < 10)
            {
                Console.Write("\nEnter the number: ");
                big = int.Parse(Console.ReadLine());
                big = big > temp ? big : temp;
                Console.WriteLine(big + " is bigger");
            }
            Console.ReadLine();
        }
    }
}
