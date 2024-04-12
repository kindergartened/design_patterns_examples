namespace SimpleDesignPatterns
{

    /// <summary>
    /// Внешний сервис, предоставляющий данные о курсах валют
    /// </summary>
    public class ExternalCurrencyService
    {
        /// <summary>
        /// Получает данные о курсах валют от внешнего сервиса.
        /// </summary>
        /// <returns>Словарь, содержащий данные о курсах валют.</returns>
        public Dictionary<string, decimal> GetRates()
        {
            // Запрос к внешнему сервису для получения данных о курсах валют
            //(в данном случае просто создаем словарь)
            Dictionary<string, decimal> rates = new Dictionary<string, decimal>
            {
                {"USD", 1.2m},
                {"EUR", 1.0m},
                {"GBP", 0.9m},
                {"JPY", 130.5m},
                {"AUD", 1.6m},
                {"CAD", 1.4m},
                {"CHF", 1.1m},
                {"CNY", 7.8m},
                {"INR", 88.7m},
                {"RUB", 89.6m}
            };
            return rates;
        }
    }
}
