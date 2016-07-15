using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_to_exit
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Write("\nEnter q to exit: ");
            } while (Console.ReadKey().KeyChar != 'q');
            Environment.Exit(0);
        }
    }
}
