using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reverse_a_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number: ");
            int n = int.Parse(Console.ReadLine());
            while(n!=0)
            {
                Console.Write(n % 10);
                n /= 10;
            }
            Console.ReadLine();
        }
    }
}
