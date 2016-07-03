using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leap_year_or_not
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the year: ");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine(year % 4 == 0 ? "Leap Year" : "Not a leap year");
            Console.ReadLine();
        }
    }
}
