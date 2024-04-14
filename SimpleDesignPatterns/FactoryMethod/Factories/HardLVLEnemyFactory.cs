using SimpleDesignPatterns.FactoryMethod.Enemies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDesignPatterns.FactoryMethod.Factories
{
    public class HardLVLEnemyFactory : IEnemyFactory
    {
        private static Random rnd = new Random();
        public IEnemy Create()
        {
            string[] enemies = new string[] {
                "Дракон",
                "Троль"
            };

            switch (enemies[rnd.Next(0, enemies.Length)])
            {
                case "Дракон":
                    return new Dragon();
                case "Троль":
                    return new Troll();
                default:
                    throw new Exception("Таких конкретных классов нет D:");
            }
        }

        public override string ToString() // реализуем приведение экземпляра класс к строке
        {
            return "Сложный уровень сложности";
        }
    }
}
