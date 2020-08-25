using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_renshu3_8
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int n = 2; n <= 100; n++)
            {
                int count = 0;
                for (int i = 1; i <= n; i++)
                {
                    if(n % i == 0)
                    {
                        count++;
                    }
                }
                if (count == 2)
                {
                    Console.Write("{0} ", n);

                }
                Console.WriteLine();
            }
        }
    }
}
