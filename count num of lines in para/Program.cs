using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace count_num_of_lines_in_para
{
    class Program
    {
        static void Main(string[] args)
        {
            /* File location "C:/File.txt" 
               File content: "This is Line 1
                              This is Line 2
                              This is Line 3
                              This is Line 4
                              This is Line 5
                              This is Line 6
                              This is Line 7
            */
            Console.WriteLine(File.ReadAllText("C:/File.txt"));
            string[] content = File.ReadAllLines("C:/File.txt");
            Console.WriteLine("Number of Lines: " + content.Length);
            Console.ReadLine();
        }
    }
}
