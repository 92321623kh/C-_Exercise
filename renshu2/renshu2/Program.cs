using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace renshu2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("円の半径を入力");
            double r = double.Parse(Console.ReadLine());
            Console.WriteLine("円の面積:{0}cm2",3.14 * r*r);
            Console.WriteLine("円周の長さ:{0}cm2", 2 * 3.14　* r);

        }
    }
}
