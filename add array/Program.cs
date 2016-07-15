using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter 5 numbers in array 1: ");
            int[] arr1 = new int[5];
            for (int i = 0; i < 5; i++)
                arr1[i] = int.Parse(Console.ReadLine());
            Console.Write("Enter 5 numbers in array 1: ");
            int[] arr2 = new int[5];
            int[] arr3 = new int[5];
            for (int i = 0; i < 5; i++)
            {
                arr2[i] = int.Parse(Console.ReadLine());
                arr3[i] = arr1[i] + arr2[i];
            }
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine(arr1[i] + " + " + arr2[i] + " = " + arr3[i]);
            }
            Console.ReadLine();

        }
    }
}
