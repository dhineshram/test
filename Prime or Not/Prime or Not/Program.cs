using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prime_or_Not
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number: ");
            int num = int.Parse(Console.ReadLine());

            string output = "Prime";
            for (int i = 2; i < num; i++)
                if(num%i==0)
                {
                    output = "Not a prime";
                    break;
                }
            Console.WriteLine("{0} is " + output + " number",num);
            Console.ReadLine();
        }
    }
}
