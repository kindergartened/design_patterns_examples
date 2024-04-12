using System;
using System.Collections.Generic;
using SimpleDesignPatterns;


namespace PatternsConsole
{
    
    class Prog
    {
        static void Main()
        {
            Console.WriteLine("Добро пожаловать в приложение для работы с курсами валют!");


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
}