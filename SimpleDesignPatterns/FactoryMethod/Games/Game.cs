using SimpleDesignPatterns.FactoryMethod.GameObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDesignPatterns.FactoryMethod.Games
{
    class Game
    {
        private RandomValley location;
        private Hero gamer;

        public Game(IEnemyFactory factory)
        {
            gamer = new Hero(); // В игре должен быть главный герой, за которого бы будем играть

            Tree[] trees = new Tree[] { // Задаём список деревьев, которые будут на локации
                new Tree(),
                new Tree(),
                new Tree()
            };

            Bonfire[] bonfires = new Bonfire[] { // Задаём список костров, которые будут на локации
                new Bonfire(),
                new Bonfire(),
                new Bonfire()
            };

            IEnemy[] enemies = new IEnemy[100]; // Задаём список монстров на локации

            for (int i = 0; i < enemies.Length; i++)
            {
                enemies[i] = factory.Create(); // заполнение массива делегировано фабричному методу
            }

            location = new RandomValley(enemies, trees, bonfires); // инициализируем игровую локацию
        }

        /// <summary>
        /// Здесь все игровые элементы взаимодействуют и рендерятся.
        /// (на самом деле нет, потому что не в этом суть данного урока)
        /// </summary>
        public void StartGame()
        {
            Console.WriteLine("Локация загружена");
            Console.WriteLine("Деревья расставлены");
            Console.WriteLine("Костры расставлены");
            Console.WriteLine("Монстры на местах");
            Console.WriteLine("Игрок загружен");
            Console.WriteLine("YESSS, INDEED");

            location.EnemyInfo(); // Выведем инфу о том, сколько и каких типов быдло у нас сгенерилось 

        }
    }
}
