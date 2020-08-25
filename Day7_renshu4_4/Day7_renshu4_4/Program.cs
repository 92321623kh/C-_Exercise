using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_renshu4_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[]  months = { 
                "１月", "２月", "３月", "４月", "５月", "６月" ,
                 "7月" , "8月", "9月", "10月", "11月", "12月" };

            Console.Write("月を入力してください:");
            int m = int.Parse(Console.ReadLine());
            if (m >= 1 && m <= months.Length)
            {
                Console.WriteLine("{0}月は英語で{1}です。", m, months[m - 1]);
            }
            else
            {
                Console.WriteLine("適切な値を入力してください");
            }
        }
    }
}
