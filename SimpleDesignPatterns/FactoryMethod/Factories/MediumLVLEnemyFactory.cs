using SimpleDesignPatterns.FactoryMethod.Enemies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDesignPatterns.FactoryMethod.Factories
{
    internal class MediumLVLEnemyFactory
    {
        private static int HardEnemyCount = 0;

        public IEnemy Create()
        {
            if (HardEnemyCount < 10) // проверяем созданы ли 10 сильных мобов
            {
                HardEnemyCount += 1;
                return new Troll(); // если нет, то создаём
            }

            // если 10 сильных врагов созданы, то генерируем остальных рандомно
            IEnemyFactory ezFactory = new EasyLVLEnemyFactory();
            return ezFactory.Create();
        }

        public override string ToString() // реализуем приведение экземпляра класс к строке
        {
            return "Средний уровень сложности";
        }
    }
}
