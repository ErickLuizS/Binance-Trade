using System.Globalization;

namespace GoogleSheetsWrapper.Utils
{
    public class CurrencyParsing
    {
        public static double ParseCurrencyString(string amount)
        {
            return double.Parse(
                amount,
                NumberStyles.Currency | NumberStyles.AllowDecimalPoint, CultureInfo.CreateSpecificCulture("en-us"));
        }

        public static string ConvertToCurrencyString(double amount)
        {
            return $"{amount:C2}";
        }
    }
}
