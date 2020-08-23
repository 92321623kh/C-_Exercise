using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample212
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("サイコロの目を入力してください：");
            int dice = int.Parse(Console.ReadLine());
            switch (dice)
            {
                case 1:
                case 3:
                case 5:
                    Console.WriteLine("奇数です");
                    break;
                case 2:
                case 4:
                case 6:
                    Console.WriteLine("偶数です");
                    break;
                default:
                    Console.WriteLine("範囲外の数値です");
                    break;
            }
        }
    }
}
