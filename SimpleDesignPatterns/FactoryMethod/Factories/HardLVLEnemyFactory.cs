using SimpleDesignPatterns.FactoryMethod.Enemies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDesignPatterns.FactoryMethod.Factories
{
    internal class HardLVLEnemyFactory : IEnemyFactory
    {
        private static Random rnd = new Random();
        public IEnemy Create()
        {
            string[] enemies = new string[] {
                "Нудист",
                "Гопник"
            };

            switch (enemies[rnd.Next(0, enemies.Length)]) // Рандомно выбираем из гопников и нудистов
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
