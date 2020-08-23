using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_reidai1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("☆の数を入力してください：");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                Console.Write("☆");
            }
            Console.WriteLine();
        }
    }
}
