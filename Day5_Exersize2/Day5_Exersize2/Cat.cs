using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_Exersize2
{
    class Cat : Mammls
    {
        public Cat()
        {
            this.name = "猫";
        }

        public override void Bark()
        {
            Console.WriteLine("にゃーにゃー");
        }
    }
}
