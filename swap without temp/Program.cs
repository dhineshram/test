using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swap_using_temp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter 2 numbers: ");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine(n1 + " " + n2 );
            n1 = n1 + n2;
            n2 = n1 - n2;
            n1 = n1 - n2;
            Console.WriteLine(n1 + " " + n2);
            Console.ReadLine();
        }
    }
}
