using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_renshu3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("回数を入力:");
            int n = int.Parse(Console.ReadLine());
            for (int i =n; i >= 0; i--)
            {
                Console.Write("{0}", n);
            }
        }
    }
}
