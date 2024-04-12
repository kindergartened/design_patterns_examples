namespace SimpleDesignPatterns
{

    /// <summary>
    /// Интерфейс для работы с данными о курсах валют
    /// </summary>
    public interface ICurrencyExchange
    {
        /// <summary>
        /// Получает курсы обмена валюты и соответствующие им ставки.
        /// </summary>
        /// <returns>Словарь, содержащий информацию о курсах обмена валюты и соответствующие им ставки.</returns>
        Dictionary<string, decimal> GetExchangeRates();

        /// <summary>
        /// Конвертирует указанную сумму из одной валюты в другую.
        /// </summary>
        /// <param name="amount">Сумма, которую необходимо конвертировать.</param>
        /// <param name="fromCurrency">Информация о валюте, из которой нужно конвертировать.</param>
        /// <param name="toCurrency">Информация о валюте, в которую нужно конвертировать.</param>
        /// <returns>Сумма в целевой валюте после конвертации.</returns>
        decimal ConvertCurrency(decimal amount, string fromCurrency, string toCurrency);

        /// <summary>
        /// выводит место где используется выбранная валюта
        /// </summary>
        /// <param name="currencyCode"> код валюты </param>
        /// <returns>Место где используется данная валюта</returns>
        string GetCountryByCurrencyCode(string currencyCode);
    }   
}