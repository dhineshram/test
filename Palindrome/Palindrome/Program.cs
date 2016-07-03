using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number: ");
            string num = Console.ReadLine();

            char[] charArray = num.ToCharArray();
            Array.Reverse(charArray);
            string rev = string.Concat(charArray);

            Console.WriteLine(num == rev ? "Palindrom" : "Not a palindrome");
            Console.ReadLine();
        }
    }
}
