using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_Exersise_3
{
    class Car : IDrive, IMechAnimal
    {
        public void Drive()
        {
            Console.WriteLine("運転する");
        }
        public void Maintain()
        {
            Console.WriteLine("メンテナンスする");
        }
    }
}
