using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_Exersise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            static void DriverACar(Car car)
            {
                car.Drive();

            }
            static void MaintainACar(string[] args)
            {
                car.Maintain();
            }
            static void Main(string[] args)
            {
                Car c = new Car();
                DriverACar(c);
                MaintainACar(c);
            }
        }
    }
}
