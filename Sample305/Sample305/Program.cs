using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample305
{
    class Program
    {
        static void Main(string[] args)
        {
            double one, two, three;
            double sum, avg;
            one = 1.1;
            two = 2.2;
            three = 3.2;
            Console.WriteLine(one + "" + two + "" + three);
            sum = one + two + three;
            avg = sum / 3.0;
            Console.WriteLine("sum": +sum);
            Console.WriteLine("avg": +avg);
        }
    }
}
