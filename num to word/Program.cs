using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numbers_in_words
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number: ");
            int num = int.Parse(Console.ReadLine());
            int backup = num, i = 0;
            int[] n = new int[5];
            while(num!=0)
            {
                n[i++] = num % 10;
                num = num / 10;
            }
            if(n[4] != 0)
            {
                if (n[4] == 1)
                {
                    switch (n[3])
                    {
                        case 0:
                            Console.Write("Ten thousand ");
                            break;
                        case 1:
                            Console.Write("Eleven thousand ");
                            break;
                        case 2:
                            Console.Write("Twelve thousand ");
                            break;
                        case 3:
                            Console.Write("Thirteen thousand ");
                            break;
                        case 4:
                            Console.Write("Fourteen thousand ");
                            break;
                        case 5:
                            Console.Write("Fifteen thousand ");
                            break;
                        case 6:
                            Console.Write("Sixteen thousand ");
                            break;
                        case 7:
                            Console.Write("Seventeen thousand ");
                            break;
                        case 8:
                            Console.Write("Eighteen thousand ");
                            break;
                        case 9:
                            Console.Write("Ninty thousand ");
                            break;
                    }
                }
                if (n[4] == 2)
                    Console.Write("Twenty ");
                if (n[4] == 3)
                    Console.Write("Thirty ");
                if (n[4] == 4)
                    Console.Write("Forty ");
                if (n[4] == 5)
                    Console.Write("Fifty ");
                if (n[4] == 6)
                    Console.Write("Sixty ");
                if (n[4] == 7)
                    Console.Write("Seventy ");
                if (n[4] == 8)
                    Console.Write("Eighty ");
                if (n[4] == 9)
                    Console.Write("Ninty ");
            }
            if(n[3] != null && n[4] != 1)
            {
                if (n[3] == 0 && n[4] != 0)
                    Console.Write("thousand ");
                if (n[3] == 1)
                    Console.Write("one thousand ");
                if (n[3] == 2)
                    Console.Write("two thousand ");
                if (n[3] == 3)
                    Console.Write("three thousand ");
                if (n[3] == 4)
                    Console.Write("four thousand ");
                if (n[3] == 5)
                    Console.Write("five thousand ");
                if (n[3] == 6)
                    Console.Write("six thousand ");
                if (n[3] == 7)
                    Console.Write("seven thousand ");
                if (n[3] == 8)
                    Console.Write("eight thousand ");
                if (n[3] == 9)
                    Console.Write("nine thousand ");
            }

            if(n[2] != null)
            {
                if (n[2] == 1)
                    Console.Write("one hundred ");
                if (n[2] == 2)
                    Console.Write("two hundred ");
                if (n[2] == 3)
                    Console.Write("three hundred ");
                if (n[2] == 4)
                    Console.Write("four hundred ");
                if (n[2] == 5)
                    Console.Write("five hundred ");
                if (n[2] == 6)
                    Console.Write("six hundred ");
                if (n[2] == 7)
                    Console.Write("seven hundred ");
                if (n[2] == 8)
                    Console.Write("eight hundred ");
                if (n[2] == 9)
                    Console.Write("nine hundred ");
            }
            if(n[1] != null)
            {
                if (n[1] == 1)
                {
                    switch (n[0])
                    {
                        case 0:
                            Console.Write("ten");
                            break;
                        case 1:
                            Console.Write("Eleven ");
                            break;
                        case 2:
                            Console.Write("Twelve ");
                            break;
                        case 3:
                            Console.Write("Thirteen ");
                            break;
                        case 4:
                            Console.Write("Fourteen ");
                            break;
                        case 5:
                            Console.Write("Fifteen ");
                            break;
                        case 6:
                            Console.Write("Sixteen ");
                            break;
                        case 7:
                            Console.Write("Seventeen ");
                            break;
                        case 8:
                            Console.Write("Eighteen ");
                            break;
                        case 9:
                            Console.Write("Ninty ");
                            break;
                    }
                }
                if (n[1] == 2)
                    Console.Write("twenty ");
                if (n[1] == 3)
                    Console.Write("thirty ");
                if (n[1] == 4)
                    Console.Write("forty ");
                if (n[1] == 5)
                    Console.Write("fifty ");
                if (n[1] == 6)
                    Console.Write("sixty ");
                if (n[1] == 7)
                    Console.Write("seventy ");
                if (n[1] == 8)
                    Console.Write("eighty ");
                if (n[1] == 9)
                    Console.Write("ninty ");
            }
            if(n[0] != null && n[1] != 1)
            {
                if (n[0] == 1)
                    Console.Write("one");
                if (n[0] == 2)
                    Console.Write("two");
                if (n[0] == 3)
                    Console.Write("three");
                if (n[0] == 4)
                    Console.Write("four");
                if (n[0] == 5)
                    Console.Write("five");
                if (n[0] == 6)
                    Console.Write("six");
                if (n[0] == 7)
                    Console.Write("seven");
                if (n[0] == 8)
                    Console.Write("eight");
                if (n[0] == 9)
                    Console.Write("nine");
            }
            Console.ReadLine();
        }
    }
}
