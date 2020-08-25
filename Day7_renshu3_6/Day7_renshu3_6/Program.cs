using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_renshu3_6
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("文字列を入力:");
                string s = Console.ReadLine();
                if (s == "")
                {
                    break;
                }
                Console.WriteLine(s);
            }
            
        }
    }
}
