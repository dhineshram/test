using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace count_num_of_char_in_line
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the line: ");
            string str = Console.ReadLine();
            int count = 0;
            char[] charArray = str.ToCharArray();
            foreach (char item in charArray)
            {
                if (item >= '0' && item <= '9')
                    count++;
            }
            Console.Write("Number of chars: " + count);
            Console.ReadLine();
        }
    }
}
