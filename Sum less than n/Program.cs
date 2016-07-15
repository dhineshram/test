using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_less_than_n
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number: ");
            int num = int.Parse(Console.ReadLine());
            for (int i = num-1; i > 0; i--)
                num += i;
            Console.WriteLine(num);
            Console.ReadLine();
        }
    }
}
