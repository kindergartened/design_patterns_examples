using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDesignPatterns.FactoryMethod.Enemies
{
    class Dragon : IEnemy
    {
        public void BatleRoar()
        {
            Console.WriteLine("I AM POWER INCARNATE!");
        }

        public override string ToString()
        {
            return "Дракон";
        }
    }
}
