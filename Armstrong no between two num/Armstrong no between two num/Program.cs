using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Armstrong_no_between_two_num
{
    class Program
    {
        static void Main(string[] args)
        {

            /* WHAT IS AN ARMSTRONG NUMBER?
                
            --->>      abcd = a^n + b^n + c^n + d^n     <<----

            where n = number of digits in the number

            */

            Console.Write("Enter the limits: ");
            int l1 = int.Parse(Console.ReadLine());     //Get limit start
            int l2 = int.Parse(Console.ReadLine());     //Get limit end

            //Initialization of all variables
            int[] array = new int[7];
            int count = 0, back = 0, i = 0, use = 0;
            double total = 0;

            //perform within limits
            for(int num= l1;num <= l2;num++)
            {
                //release variables for every number
                back = num; use = num; i = 0; count = 0; total = 0;

                // seperate each digit of the number
                while (use != 0)
                {
                    array[i] = use % 10;
                    use /= 10;
                    count++;
                    i++;
                }

                // checking the sum with the number & prints if equal
                for (i = 0; i < count; i++)
                    total += Math.Pow(array[i], count);
                if (total == back)
                    Console.WriteLine(back);
            }
            Console.ReadLine();
        }
    }
}
