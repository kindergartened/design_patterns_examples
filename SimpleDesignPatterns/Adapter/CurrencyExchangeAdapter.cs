namespace SimpleDesignPatterns
{

    /// <summary>
    /// Адаптер для адаптации данных о курсах валют из внешнего сервиса
    /// </summary>
    public class CurrencyExchangeAdapter : ICurrencyExchange
    {
        private ExternalCurrencyService _externalService;

        /// <summary>
        /// Инициализирует новый экземпляр класса CurrencyExchangeAdapter с указанным внешним сервисом.
        /// </summary>
        /// <param name="externalService">Внешний сервис, предоставляющий данные о курсах валют.</param>
        public CurrencyExchangeAdapter(ExternalCurrencyService externalService)
        {
            _externalService = externalService;
        }

        /// <summary>
        /// Получает курсы обмена валюты и соответствующие им ставки, адаптируя их к формату внутренней системы.
        /// </summary>
        /// <returns>Словарь, содержащий информацию о курсах обмена валюты и соответствующие им ставки в формате внутренней системы.</returns>
        public Dictionary<string, decimal> GetExchangeRates()
        {
            // Получаем данные о курсах валют из внешнего сервиса
            Dictionary<string, decimal> externalRates = _externalService.GetRates();

            return externalRates;
        }

        /// <summary>
        /// Конвертирует указанную сумму из одной валюты в другую, используя курсы обмена валюты.
        /// </summary>
        /// <param name="amount">Сумма, которую необходимо конвертировать.</param>
        /// <param name="fromCurrency">Информация о валюте, из которой нужно конвертировать.</param>
        /// <param name="toCurrency">Информация о валюте, в которую нужно конвертировать.</param>
        /// <returns>Сумма в целевой валюте после конвертации.</returns>
        public decimal ConvertCurrency(decimal amount, string fromCurrency, string toCurrency)
        {
            
            Dictionary<string, decimal> rates = GetExchangeRates();
            decimal fromRate = GetRateOrThrowError(rates, fromCurrency);
            decimal toRate = GetRateOrThrowError(rates, toCurrency);
            decimal result = amount * toRate / fromRate;
            return result;
        }

        /// <summary>
        /// Вспомогательная функция проверяющая существует ли валюта выбранная пользователем
        /// </summary>
        /// <param name="rates"> словарь с валютами </param>
        /// <param name="currencyInfo"> выбранная валюта </param>
        /// <returns> курс валюты </returns>
        /// <exception cref="ArgumentException"> ошибка если данной валюты нет </exception>
        private decimal GetRateOrThrowError(Dictionary<string, decimal> rates, string currencyInfo)
        {
            if (!rates.ContainsKey(currencyInfo))
            {
                throw new ArgumentException($"Currency '{currencyInfo}' not found.");
            }
            return rates[currencyInfo];
        }

        /// <summary>
        /// выводит место где используется выбранная валюта
        /// </summary>
        /// <param name="currencyCode"> код валюты </param>
        /// <returns>Место где используется данная валюта</returns>
        public string GetCountryByCurrencyCode(string currencyCode)
        {
            // В реальном приложении здесь может быть словарь с соответствием кодов валют и стран
            switch (currencyCode)
            {
                case "USD": return "США";
                case "EUR": return "Еврозона";
                case "GBP": return "Великобритания";
                case "JPY": return "Япония";
                case "AUD": return "Австралия";
                case "CAD": return "Канада";
                case "CHF": return "Швейцария";
                case "CNY": return "Китай";
                case "INR": return "Индия";
                case "RUB": return "Россия";
                default: return "Неизвестно";
            }
        }
    }
}