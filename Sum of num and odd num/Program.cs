using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_of_num_and_odd_num
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0, output = 0;
            for(i = 0; i <= 15; i++)
                output += i;
            Console.WriteLine(output);
            i = 1;
            output = 1;
            for(i = 15; i <= 45; i++)
                output += (i%2 != 0 ? 15 : 0);
            Console.WriteLine(output);
            Console.ReadLine();
        }
    }
}
