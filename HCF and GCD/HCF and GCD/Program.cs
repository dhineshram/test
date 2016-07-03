using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HCF_and_GCD
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.Write("Enter two numbers: ");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            if(n2>n1)
            {
                int temp = n1;
                n1 = n2;
                n2 = temp;
            }
            int[] n1a = new int[n1];
            int[] n2a = new int[n2];
            int[] hcf = new int[n1];
            int j = 0, i = 0, k = 0;

            for (i = 1; i <= n1; i++)
                if (n1 % i == 0)
                    n1a[j++] = i;
            
            j = 0;

            for (i = 1; i < n2; i++)
                if (n2 % i == 0)
                    n2a[j++] = i;

            for (i = 0; i < n1; i++)
                for (j = 0; j < n2; j++)
                    if (n1a[i] == n2a[j] && n2a[j] != 0)
                        hcf[k++] = n1a[i];

            int t = 0;
            for (i = 1; i < n1; i++)
                if (hcf[i] > hcf[i - 1])
                    t = hcf[i];
            Console.WriteLine("\nHCF is " + t);
            Console.ReadLine();
        }
    }
}
