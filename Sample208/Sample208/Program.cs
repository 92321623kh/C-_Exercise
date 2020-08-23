using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample208
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("整数値を入力してください：");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("a = " + a);
            if (a > 0)
            {
                Console.WriteLine("入力した値は自然数です");
            }
            else
            {
                Console.WriteLine("入力した値は正の整数ではありません");
            }
        }
    }
}
