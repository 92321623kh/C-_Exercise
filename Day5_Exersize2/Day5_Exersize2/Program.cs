using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_Exersize2
{
    class Program
    {
        static void Main(string[] args)
        {
            Mammls[] animals = new Mammls[2];
            animals[0] = new Cat();
            animals[1] = new Mice();
            for (int i = 0; i < animals.Length; i++)
            {
                animals[i].ShowName();
                animals[i].Bark();
                Console.WriteLine("---------");
            }
            
        }
    }
}
