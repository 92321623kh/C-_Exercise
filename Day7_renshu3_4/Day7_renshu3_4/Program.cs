using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_renshu3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("回数を入力:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("2の倍数");
            for (int i = 2; i <= n; i += 2)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine("3の倍数");
            for (int i = 3; i <= n; i += 3)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine("5の倍数");
            for (int i = 5; i <= n; i += 5)
            {
                Console.Write("{0} ", i);
            }
        }
    }
}
