using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Armstrong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number: ");
            int num = int.Parse(Console.ReadLine());
            int back = num, i = 0, count = 0;
            int[] array = new int[5];
            while(num!=0)
            {
                array[i] = num % 10;
                num /= 10;
                count++;
                i++;
            }
            double tot = 0;
            for (i = 0; i < count; i++)
                tot += Math.Pow(array[i], count);
            string output = "Not armstrong number";
            if (tot == back)
                output = "Armstrong number";
            Console.WriteLine(output);
            Console.ReadLine();
        }
    }
}
