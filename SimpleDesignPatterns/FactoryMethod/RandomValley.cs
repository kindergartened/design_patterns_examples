using SimpleDesignPatterns.FactoryMethod.GameObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDesignPatterns
{
    /// <summary>
    /// Класс представляющий локацию
    /// </summary>
    class RandomValley
    {
        /// <summary>
        /// Монстры, обитающие на локации
        /// </summary>
        private IEnemy[] enemies;

        /// <summary>
        /// Деревья на локации 
        /// </summary>
        private Tree[] trees;

        /// <summary>
        /// Костры на локации
        /// </summary>
        private Bonfire[] bonfires;

        public RandomValley(IEnemy[] enemies, Tree[] trees, Bonfire[] bonfires)
        {
            this.enemies = enemies;
            this.trees = trees;
            this.bonfires = bonfires;
        }

        /// <summary>
        /// Выводит информацию по количеству быдла определённого типа в консоль
        /// </summary>
        public void EnemyInfo()
        {
            var dragon = enemies.Where((item) => {
                return item.ToString() == "Дракон";
            }).Count();

            Console.WriteLine($"{dragon} Дракон");


            var troll = enemies.Where((item) => {
                return item.ToString() == "Троль";
            }).Count();

            Console.WriteLine($"{troll} Троль");


            var merfolk = enemies.Where((item) => {
                return item.ToString() == "Мерфолк";
            }).Count();

            Console.WriteLine($"{merfolk} Мерфолк");
        }

    }
}

