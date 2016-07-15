using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter two numbers: ");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int temp = 0, result = 0;
            if (n1 > n2)
            {
                temp = n1;
                n1 = n2;
                n2 = temp;
            }
            for (int i=1;i<=n2;i++)
            {
                temp = n1 * i;
                if (temp % n2 == 0)
                {
                    result = temp;
                    break;
                }
            }
            Console.Write("LCM is " + result);
            Console.ReadLine();
        }
    }
}
