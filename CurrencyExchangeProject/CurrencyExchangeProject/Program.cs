/*
* Hangi para birimini dönüştürmek istiyorsunuz?
* 1. TRY
* 2. USD
* 3. EUR
* 
* Hangi para birimine dönüştürmek istiyorsunuz?
* 1. TRY
* 2. USD
* 3. EUR
* 
* Lütfen dönüştürmek istediğiniz tutarı yazınız
* 3000
* 
* Yapılacak işlem
* 3000 EUR miktarındaki paranın USD karşılığı hesaplanıyor...
* 
* 3255 USD
* 
* Devam etmek istiyor musunuz? E/H
* 
*/

while (true)
{
    PrintMenu1();
    int selection1 = GetMenuSelection();
    PrintMenu2();
    int selection2 = GetMenuSelection();
    PrintAmountMessage();
    double amount = GetAmount();
   

    double result = CalculateCurrencyExchange(selection1, selection2, amount);
    Console.WriteLine(result);
}
double CalculateCurrencyExchange(int selection1,int selection2,double amount)
{
    double[] rates ={1,0.051,0.047,0.908,1.101};

    // TRY--->USD
    if (selection1==1 && selection2==2)
    {
       amount= amount * rates[1];
    }
    //TRY--->EUR
    else if (selection1==1 && selection2==3)
    {
       amount= amount * rates[2];
    }
    //USD--->EUR
    else if (selection1 == 2 && selection2 == 3)
    {
        amount = amount * rates[3];
    }
    //EUR--->USD
    else if (selection1 == 3 && selection2 == 2)
    {
        amount=amount * rates[4];
    }
    else
    {
        amount = amount;
    }
    return amount;
}
double GetAmount()
{
    while (true)
    {
        string input = Console.ReadLine();

        if (double.TryParse(input, out double amount))
        {
            return amount;
        }
        else
        {
            Console.WriteLine("Geçersiz bir miktar girdiniz. Lütfen tekrar deneyin:");
        }
    }
}
void PrintAmountMessage()
{
    Console.WriteLine("lütfen dönüştürmek istediğiniz tutarı yazınız");
   

}
void PrintMenu1()
{
    Console.WriteLine("Hangi para birimini dönüştürmek istiyorsunuz?");
    Console.WriteLine("1.TRY");
    Console.WriteLine("2.USD");
    Console.WriteLine("3.EUR");
}

void PrintMenu2()
{
    Console.WriteLine("Hangi para birimine dönüştürmek istiyorsunuz?");
    Console.WriteLine("1.TRY");
    Console.WriteLine("2.USD");
    Console.WriteLine("3.EUR");
}

int GetMenuSelection()
{
    int selection = 0;
    while (true)
    {
        ConsoleKeyInfo keyInfo = Console.ReadKey();

        if (keyInfo.KeyChar != '1' &&
            keyInfo.KeyChar != '2' &&
            keyInfo.KeyChar != '3')
        {
            Console.Write('\b');
            Console.WriteLine("Hatalı bir giriş yaptınız, lütfen tekrar deneyin");
        }
        else
        {
            // switch-case
            switch (keyInfo.KeyChar)
            {
                case '1':
                    selection = 1;
                    break;
                case '2':
                    selection = 2;
                    break;
                case '3':
                    selection = 3;
                    break;
                default:
                    selection = 0;
                    break;
            }

            break;
        }

        //string validChars = "123";
        //if (!validChars.Contains(keyInfo.KeyChar))
        //{

        //}
    }

    return selection;
}


double[] rates =
{
    1,
    0.051,
    0.047
};