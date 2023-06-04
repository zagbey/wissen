using System;

class Program
{
    static double TRYtoUSD = 19.56;
    static double TRYtoEUR = 21.53;

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Hangi para biriminden dönüştürmek istersiniz? (TRY/USD/EUR)");
            string fromCurrency = GetCurrencyInput();

            Console.WriteLine("Hangi para birimine dönüştürmek istersiniz? (TRY/USD/EUR)");
            string toCurrency = GetCurrencyInput();

            Console.WriteLine("Dönüştürmek istediğiniz miktarı girin:");
            double amount = GetAmountInput();

            double result = ConvertCurrency(fromCurrency, toCurrency, amount);

            Console.WriteLine("{0} {1} = {2} {3}", amount, fromCurrency, result, toCurrency);

            Console.WriteLine("Devam etmek için ENTER tuşuna basın, programdan çıkmak için 'exit' yazın:");
            string input = Console.ReadLine().ToLower();

            if (input == "exit")
            {
                break;
            }
        }
    }

    static string GetCurrencyInput()
    {
        while (true)
        {
            string input = Console.ReadLine().ToUpper();

            if (input == "TRY" || input == "USD" || input == "EUR")
            {
                return input;
            }
            else
            {
                Console.WriteLine("Geçersiz bir para birimi girdiniz. Lütfen tekrar deneyin: (TRY/USD/EUR)");
            }
        }
    }

    static double GetAmountInput()
    {
        while (true)
        {
            string input = Console.ReadLine();

            if (double.TryParse(input, out double result))
            {
                return result;
            }
            else
            {
                Console.WriteLine("Geçersiz bir miktar girdiniz. Lütfen tekrar deneyin:");
            }
        }
    }

    static double ConvertCurrency(string fromCurrency, string toCurrency, double amount)
    {
        if (fromCurrency == "TRY")
        {
            switch (toCurrency)
            {
                case "USD":
                    return amount / TRYtoUSD;
                case "EUR":
                    return amount / TRYtoEUR;
                default:
                    return amount;
            }
        }
        else if (fromCurrency == "USD")
        {
            switch (toCurrency)
            {
                case "TRY":
                    return amount * TRYtoUSD;
                case "EUR":
                    return amount * (TRYtoEUR / TRYtoUSD);
                default:
                    return amount;
            }
        }
        else if (fromCurrency == "EUR")
        {
            switch (toCurrency)
            {
                case "TRY":
                    return amount * TRYtoEUR;
                case "USD":
                    return amount * (TRYtoUSD / TRYtoEUR);
                default:
                    return amount;
            }
        }
        else
        {
            return amount;
        }
    }
}
