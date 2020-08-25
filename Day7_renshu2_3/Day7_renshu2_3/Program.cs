using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_renshu2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("テストの値を入力してください (0-100)");
            int n = int.Parse(Console.ReadLine());
            if (n >= 0 && n <= 100)
            {
                if (n >= 80)
                {
                    Console.Write("優");
                }
                else if (n >= 70)
                {
                    Console.Write("良");
                }
                else if (n >= 60)
                {
                    Console.Write("可");
                }
                else
                {
                    Console.Write("不可");
                }
            }
   
        else
        {
            Console.Write("不適切");
        }
      }

    }
}
