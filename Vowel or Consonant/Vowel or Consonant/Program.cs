using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vowel_or_Consonant
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the charecter: ");
            char word = char.Parse(Console.ReadLine());
            
            string compare = "aeiouAEIOU";
            char[] charArray = compare.ToArray();

            string condition = "Vowel";
            foreach (char charcter in charArray)
            {
                if (charcter == word)
                {
                    condition = "Vowel";
                    break;
                }
                else
                    condition = "Consonant";
            }

            Console.WriteLine(condition);
            Console.ReadLine();
        }
    }
}
