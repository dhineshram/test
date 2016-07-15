using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCII
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the string: ");
            string str = Console.ReadLine();
            byte[] strASCII = Encoding.ASCII.GetBytes(str);
            foreach (byte temp in strASCII)
            {
                Console.WriteLine(temp);
            }
            Console.ReadLine();
        }
    }
}
