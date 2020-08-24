using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace renshu3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a =:");
            double a = double.Parse(Console.ReadLine());

            Console.Write("b =:");
            double b = double.Parse(Console.ReadLine());


            Console.Write("c =:");
            double c = double.Parse(Console.ReadLine());

            double total = a + b + c;
            double average = total / 3.0;
            Console.WriteLine("a + b + c = {0}", total);
            Console.WriteLine("abcの平均 = {0}", average);
        }
    }
}
