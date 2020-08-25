using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_renshu3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("forループ:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("★");
            }
            Console.WriteLine();
            Console.Write("whileループ:");
            int n = 0;
            while (n < 5)
            {
                Console.Write("★");
                n++;
            }
            Console.WriteLine();
            Console.Write("do～whileループ:");

            n = 0;
            do
            {
                Console.Write("★");
                n++;
            }
            while (n < 5);
            {
                Console.WriteLine();
            }
        }
    }
}
