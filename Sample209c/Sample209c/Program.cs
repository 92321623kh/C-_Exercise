using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample209c
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1から3の数字を入力してください");
            int num = int.Parse(Console.ReadLine());
            if (num == 1)
            {
                Console.WriteLine("one");
            }
            else if (num == 2)
            {
                Console.WriteLine("two");
            }
            else if (num == 3)
            {
                Console.WriteLine("three");
            }
            else
            {
                Console.WriteLine("不適切な値が入力されました");
            }
        }
    }
}
