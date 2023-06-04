CarSelection();

int cartype = GetCarTypeSelection();
double duration = GetHourInput();
decimal amount = CalculateAmount(cartype, duration);

Console.WriteLine($"Toplam ücret = {amount} ₺");



void CarSelection()
{
    Console.WriteLine("****** ARAÇ TİPİ SEÇİNİZ ******");
    Console.WriteLine("1. Otomobil için 1’e basın\r\n2. Motosiklet için 2’ye basın\r\n3. Minibüs için 3’e basın\r\n4. Kamyon (ve diğer ticari araçlar) için 4’e basın");

}
int GetCarTypeSelection()
{
    string valdiSelection = "1234"; // geçerli keyinfoları giriyoruz 
    ConsoleKeyInfo keyInfo;
    do
    {
        keyInfo=Console.ReadKey(true);

    } while (!valdiSelection.Contains(keyInfo.KeyChar));
    switch(keyInfo.KeyChar)
    {
        case '1':
            return 1;
        case '2':
            return 2;
        case '3':
            return 3;
        case '4':
            return 4;
        default:
            throw new InvalidOperationException();
    }
}

double GetHourInput()
{

    bool parseResult = false;
    double number;
    do
    {
        Console.WriteLine("araç kaç saat boyunca park alanında kaldı");
        string input = Console.ReadLine();

        parseResult = double.TryParse(input, out number);

        if (!parseResult)
        {
            Console.WriteLine("lütfen geçerli bir sayı giriniz ");
        }


    } while (!parseResult);
    return number;
}

decimal CalculateAmount(int cartype, double duration)
{
    switch (cartype)
    {
        case 1:
            return CalculateCarFee(duration);
        case 2:
            return CalculateMotocycleFee(duration);// motocyle 
        default:
            throw new InvalidOperationException();
    }
}
decimal CalculateCarFee(double duration)
{
    decimal amount;

    if (duration < 2)
    {
        amount = 5;
    }
    else if (duration < 6)
    {
        amount = 10;
    }
    else if (duration < 12)
    {
        amount = 20;
    }
    else if (duration < 24)
    {
        amount = 35;
    }
    else
    {
        int totalDays = (int)(duration / 24);
        amount = 35 + (totalDays * 20);
    }
    return amount;
}
decimal CalculateMotocycleFee(double duration)
{
    decimal amount;

    if (duration < 2)
    {
        amount = 0;
    }
    else if (duration < 6)
    {
        amount = 3;
    }
    else if (duration < 12)
    {
        amount = 6;
    }
    else if (duration < 24)
    {
        amount = 12;
    }
    else { int totalDays = (int)(duration / 24);
            amount=12+(totalDays * 10);
    }
    return amount;
}