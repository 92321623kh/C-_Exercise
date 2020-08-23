using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample210
{
    class Program
    {
        static void Main(string[] args)
        {
            // さいころの目
            Console.Write("サイコロの目（1-6）を入力してください：");
            int dice = int.Parse(Console.ReadLine());
            if (1 <= dice && dice <= 6)
            {
                if (dice % 2 == 0)
                {
                    Console.WriteLine("丁です");
                }
                else
                {
                    Console.WriteLine("半です");
                }
            }
            else
            {
                Console.WriteLine("範囲外の数値です");
            }
        }
    }
}
