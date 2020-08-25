using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_renshu5_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = -1, min = 101;
            Random rnd = new Random();

            for (int i = 0; i < 5; i++)
            {
                int n = rnd.Next(1, 101);
                Console.Write("{0} ", n);
                if(n > max)
                {
                    max = n;
                }
                if(n < min)
                {
                    min = n;
                }
                Console.WriteLine();
                Console.WriteLine("最大値:{0}", max);
                Console.WriteLine("最小値:{0}", min);
            }
        }
    }
}
