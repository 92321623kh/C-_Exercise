using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_Exersize1
{
    class Program
    {
        static void Main(string[] args)
        {
            Ship ship = new Ship();
            BattleShip battleShip = new BattleShip();

            ship.Sail();
            battleShip.Sail();
            battleShip.Fight();
        }
    }
}
