using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample202
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;// 変数の宣言
            int b = 3;// 宣言と初期化を同時に行う
            int add, sub;// 複数の変数を同時に宣言
            double avg;// int以外の変数を宣言
            a = 6;
            add = a + b;
            sub = a - b;
            avg = (a + b) / 2.0;
            Console.WriteLine("{0} + {1} = {2}", a, b, add);
            Console.WriteLine("{0} - {1} = {2}", a, b, sub);
            Console.WriteLine("{0}と{1}の平均は{2}", a, b, avg);

        }
    }
}
