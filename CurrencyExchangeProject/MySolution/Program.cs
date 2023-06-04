//double amount = 0;
//string currencyFrom = "";
//string currencyTo = "";

//Console.Write("Amount: ");
//amount = Convert.ToDouble(Console.ReadLine());

//Console.Write("From Currency (TRY, USD, EUR): ");
//currencyFrom = Console.ReadLine().ToUpper();

//Console.Write("To Currency (TRY, USD, EUR): ");
//currencyTo = Console.ReadLine().ToUpper();

//double convertedAmount = ConvertCurrency(amount, currencyFrom, currencyTo);

//Console.WriteLine("Converted amount: " + convertedAmount);


// double ConvertCurrency(double amount, string currencyFrom, string currencyTo)
//{
//    double rate = 0;

//    if (currencyFrom == "TRY")
//    {
//        if (currencyTo == "USD")
//        {
//            rate = 1 / 19.56;
//        }
//        else if (currencyTo == "EUR")
//        {
//            rate = 1 / 21.53;
//        }
//        else
//        {
//            rate = 1;
//        }
//    }
//    else if (currencyFrom == "USD")
//    {
//        if (currencyTo == "TRY")
//        {
//            rate =  19.56;
//        }
//        else if (currencyTo == "EUR")
//        {
//            rate = 21.53 / 19.56;
//        }
//        else
//        {
//            rate = 1;
//        }
//    }
//    else if (currencyFrom == "EUR")
//    {
//        if (currencyTo == "TRY")
//        {
//            rate = 1 / 21.53;
//        }
//        else if (currencyTo == "USD")
//        {
//            rate = 19.56 / 21.53;
//        }
//        else
//        {
//            rate = 1;
//        }
//    }
//    else
//    {
//        Console.WriteLine("Invalid input");
//        return 0;
//    }

//    return amount * rate;


//}
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
            string fromCurrency = Console.ReadLine().ToUpper();

            Console.WriteLine("Hangi para birimine dönüştürmek istersiniz? (TRY/USD/EUR)");
            string toCurrency = Console.ReadLine().ToUpper();

            Console.WriteLine("Dönüştürmek istediğiniz miktarı girin:");
            double amount = Convert.ToDouble(Console.ReadLine());

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
