using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace renshu4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("幅=:");
            double width = double.Parse(Console.ReadLine());
            Console.Write("奥行=:");
            double depth = double.Parse(Console.ReadLine());
            Console.Write("高さ=:");
            double hight = double.Parse(Console.ReadLine());

            Console.WriteLine("立方体の体積　= {0}cm3", width * depth * hight);
        }
    }
}
