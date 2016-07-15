using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld_no_semicolan
{
    class Program
    {
        static void Main(string[] args)
        {
            if(Console.WriteLine("Hello World") is object)
            {
                /* Console.ReadLine();

                   Since the above line is not provided, program would 
                   open and close immediately. But Prints "Hello World"
                   That is because, the program should not include  " ; "           */
            }

        }
    }
}
