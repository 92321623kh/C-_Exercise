using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample211
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1から3の数字を入力：");
            int num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Console.WriteLine("one");
                    break;
                case 2:
                    Console.WriteLine("two");
                    break;
                case 3:
                    Console.WriteLine("three");
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }
        }
    }
}
