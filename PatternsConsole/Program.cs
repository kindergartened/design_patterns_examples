using SimpleDesignPatterns;
using SimpleDesignPatterns.FactoryMethod.Factories;
using SimpleDesignPatterns.FactoryMethod.Games;
using SimpleDesignPatterns.Strategy;

namespace PatternsConsole;

class Program
{
    static void Main()
    {
        Context context = new Context(new SqliteDatabaseStrategy());
        context.ExecuteQuery($"CREATE TABLE IF NOT EXISTS Users (Id INT, Name TEXT)");
        Console.WriteLine();
        
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

        IBeverage<Espresso> beverage = new Espresso();
        Console.WriteLine(beverage.GetDescription() + ": " + beverage.GetCost());

        IBeverage<Espresso> beverageWithMilk = new MilkDecorator(beverage);
        Console.WriteLine(beverageWithMilk.GetDescription() + ": " + beverageWithMilk.GetCost());

        IBeverage<Espresso> beverageWithMilkAndSugar = new SugarDecorator(beverageWithMilk);
        Console.WriteLine(beverageWithMilkAndSugar.GetDescription() + ": " + beverageWithMilkAndSugar.GetCost());


        Console.WriteLine("Добро пожаловать в приложение для работы с курсами валют!");


        Console.ReadKey();
        
        ExternalCurrencyService externalService = new ExternalCurrencyService();

        ICurrencyExchange currencyExchange = new CurrencyExchangeAdapter(externalService);

        Dictionary<string, decimal> exchangeRates = currencyExchange.GetExchangeRates();

        Console.WriteLine("Курсы валют:");
        foreach (var rate in exchangeRates)
        {
            Console.WriteLine($"{rate.Key} ({currencyExchange.GetCountryByCurrencyCode(rate.Key)}): {rate.Value}");
        }
        Console.WriteLine("\nВведите сумму и коды валют (пример, 100 RUB USD):");

        string input = Console.ReadLine();
        string[] inputParts = input.Split(' ');
        if (inputParts.Length != 3)
        {
            Console.WriteLine("Неверный формат ввода.");
            return;
        }

        if (!decimal.TryParse(inputParts[0], out decimal amount))
        {
            Console.WriteLine("Неверный формат суммы.");
            return;
        }
        
        try
        {
            decimal convertedAmount = currencyExchange.ConvertCurrency(amount, inputParts[1], inputParts[2]);
            Console.WriteLine($"Результат конвертации: {amount} {inputParts[1]} = {convertedAmount} {inputParts[2]}.");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }
}