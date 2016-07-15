using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coompare_string_without_strcmp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter two strings: ");
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
            Console.WriteLine(str1 == str2 ? "Siimilar" : "Not similar");
            Console.ReadLine();
        }
    }
}
