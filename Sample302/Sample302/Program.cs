using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample302
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int i = 1; i <= 5; i++)
                {
                    int k = i + j;
                    Console.Write(i + "+"+ j +"=" + k +"");
                }
                Console.WriteLine();
            }
        }
    }
}
