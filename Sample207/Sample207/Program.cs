using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample207
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("数値を入力してください:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("a = " + a);
            if (a > 0)
                Console.WriteLine("入力された値は正の数です");
        }
    }
}
