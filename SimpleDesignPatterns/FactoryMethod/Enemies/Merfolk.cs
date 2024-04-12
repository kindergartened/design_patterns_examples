using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDesignPatterns.FactoryMethod.Enemies
{
    class Merfolk : IEnemy
    {
        public void BatleRoar()
        {
            Console.WriteLine("МРГРЛМРГЛРМГМРЛГЛ");
        }

        public override string ToString()
        {
            return "Мерфолк";
        }
    }
}
