using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_renshu4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = new string[5];
            for (int i = 0; i < s.Length; i++)
            {
                Console.Write("{0}つ目の文字列を入力:", i+1);
                s[i] = Console.ReadLine();
            }
            foreach(string str in s)
            {
                Console.Write("{0} ", str);
            }
            Console.WriteLine();
        }
    }
}
