using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter 3 integers: ");
            int[] num = new int[3];
            for (int i = 0; i < 3; i++)
                num[i] = int.Parse(Console.ReadLine());
            Array.Sort(num);
            Console.WriteLine("\nBiggest is " + num[2]);
            Console.ReadLine();
        }
    }
}
