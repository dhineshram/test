using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace concat_without_strcat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter two strings: ");
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
            string join = str1 + str2;
            Console.WriteLine(join);
            Console.ReadLine();
        }
    }
}
