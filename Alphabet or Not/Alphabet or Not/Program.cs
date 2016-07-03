using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Alphabet_or_Not
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the charecter: ");
            char character = char.Parse(Console.ReadLine());

            string compare= "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            char[] charArray = compare.ToCharArray();

            string output = "Not an alphabet";
            foreach (char a in charArray)
                if (a == character)
                    output = "Alphabet";
            Console.WriteLine(output);
            Console.ReadLine();
        }
    }
}
