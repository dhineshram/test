using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_number_of_char_num_alphanum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the string: ");
            string str = Console.ReadLine();
            char[] charArray = str.ToCharArray();
            int nchar = 0, num = 0, alphanum = 0;
            foreach (char ch in charArray)
            {
                if (ch >= 'a' && ch <= 'z')
                    nchar++;
                else if (ch >= '0' && ch <= '9')
                    num++;
                else
                    alphanum++;
            }
            Console.WriteLine("Number of\nCharacter: {0}\nAlphabets: {1}\nAlphanumeric Characters: {2}", num, nchar, alphanum);
            Console.ReadLine();
        }

    }
}
