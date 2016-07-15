using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace count_num_of_words
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the line: ");
            string str = Console.ReadLine();
            int count = 1;
            char[] charArray = str.ToCharArray();
            foreach (char item in charArray)
            {
                if (item == ' ')
                    count++;
            }
            Console.Write("Number of words: " + count);
            Console.ReadLine();
        }
    }
}
