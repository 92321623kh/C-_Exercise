using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_Exersize2
{
    class Mice : Mammls
    {
        public Mice()
        {
            this.name = "ネズミ";
        }
        public override void Bark()
        {
            Console.WriteLine("チューチュー");
        }
    }
}
