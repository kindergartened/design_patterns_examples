using SimpleDesignPatterns;
using SimpleDesignPatterns.FactoryMethod.Factories;
using SimpleDesignPatterns.FactoryMethod.Games;

namespace PatternsConsole;

class Program
{
    static void Main()
    {
        /*
         _______  _______  _______ _________ _______  _______             _______  _______ _________          _______  ______  
        (  ____ \(  ___  )(  ____ \\__   __/(  ___  )(  ____ )|\     /|  (       )(  ____ \\__   __/|\     /|(  ___  )(  __  \ 
        | (    \/| (   ) || (    \/   ) (   | (   ) || (    )|( \   / )  | () () || (    \/   ) (   | )   ( || (   ) || (  \  )
        | (__    | (___) || |         | |   | |   | || (____)| \ (_) /   | || || || (__       | |   | (___) || |   | || |   ) |
        |  __)   |  ___  || |         | |   | |   | ||     __)  \   /    | |(_)| ||  __)      | |   |  ___  || |   | || |   | |
        | (      | (   ) || |         | |   | |   | || (\ (      ) (     | |   | || (         | |   | (   ) || |   | || |   ) |
        | )      | )   ( || (____/\   | |   | (___) || ) \ \__   | |     | )   ( || (____/\   | |   | )   ( || (___) || (__/  )
        |/       |/     \|(_______/   )_(   (_______)|/   \__/   \_/     |/     \|(_______/   )_(   |/     \|(_______)(______/ 
        */
        IEnemyFactory[] lvls = new IEnemyFactory[] { // инициализируем уровни сложности, пользователь будет их выбирать
                new EasyLVLEnemyFactory(),
                new MediumLVLEnemyFactory(),
                new HardLVLEnemyFactory()
            };

        Console.WriteLine("Выберете уровень сложности и введите его номер:");

        for (int i = 0; i < lvls.Length; i++) // выведем все уровни сложности пользователю
        {
            Console.WriteLine($"{i + 1}. {lvls[i].ToString()}");
        }

        int lvlNumber = Convert.ToInt32(Console.ReadLine()) - 1;

        if (lvlNumber > -1 && lvlNumber < lvls.Length)
        {
            Game game = new Game(lvls[lvlNumber]);
            game.StartGame();
        }
        else
        {
            Console.WriteLine("Недопустимое число");
        }

        Console.ReadKey();

        /*  _____  ______ _____ ____  _____         _______ ____  _____  
            |  __ \|  ____/ ____/ __ \|  __ \     /\|__   __/ __ \|  __ \ 
            | |  | | |__ | |   | |  | | |__) |   /  \  | | | |  | | |__) |
            | |  | |  __|| |   | |  | |  _  /   / /\ \ | | | |  | |  _  / 
            | |__| | |___| |___| |__| | | \ \  / ____ \| | | |__| | | \ \ 
            |_____/|______\_____\____/|_|  \_\/_/    \_\_|  \____/|_|  \_\                                                
         */
        IBeverage<Espresso> beverage = new Espresso();
        Console.WriteLine(beverage.GetDescription() + ": " + beverage.GetCost());

        IBeverage<Espresso> beverageWithMilk = new MilkDecorator(beverage);
        Console.WriteLine(beverageWithMilk.GetDescription() + ": " + beverageWithMilk.GetCost());

        IBeverage<Espresso> beverageWithMilkAndSugar = new SugarDecorator(beverageWithMilk);
        Console.WriteLine(beverageWithMilkAndSugar.GetDescription() + ": " + beverageWithMilkAndSugar.GetCost());



        
    }
}