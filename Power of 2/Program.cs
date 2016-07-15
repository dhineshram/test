using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pow_of_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number: ");
            int n = int.Parse(Console.ReadLine());
            double calc = 0, i = -1;
            while (calc < n)
            {
                i++;
                calc = Math.Pow(2, i);
                if (calc == n)
                    goto Here;
            }
            goto There;
            Here:
            Console.WriteLine(n + " is " + i + " power of 2");
            goto skip;
            There:
            Console.WriteLine(n + " is not a power of 2");
            skip:
            Console.ReadLine();
        }
    }
}
