using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDesignPatterns.FactoryMethod.Enemies
{
    class Troll : IEnemy
    {
        public void BatleRoar()
        {
            Console.WriteLine("Taz'dingo HHAHAHAHA");
        }

        public override string ToString()
        {
            return "Троль";
        }
    }
}
