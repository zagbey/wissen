CarSelection(); // araç seçim ekranı 
int selection = GetMenuSelection(); // girilen inputun int değere atanması 
Console.WriteLine();
Console.WriteLine("Araç kaç saat boyunca park alanında kaldı?");
double parkingtime = GetHours();

double finalprice = CalculateParkingPrice(selection, parkingtime);
Console.WriteLine("ÖDEMENİZ GEREKEN ÜCRET {0}₺", finalprice);

void CarSelection()
{
    Console.WriteLine("****** ARAÇ TİPİ SEÇİNİZ ******");
    Console.WriteLine("1. Otomobil için 1’e basın\r\n2. Motosiklet için 2’ye basın\r\n3. Minibüs için 3’e basın\r\n4. Kamyon (ve diğer ticari araçlar) için 4’e basın");

}
int GetMenuSelection()
{
    int selection = 0;
    while (true)
    {
        ConsoleKeyInfo keyInfo = Console.ReadKey();

        if (keyInfo.KeyChar != '1' &&
            keyInfo.KeyChar != '2' &&
            keyInfo.KeyChar != '3' &&
            keyInfo.KeyChar != '4')
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
                case '4':
                    selection = 4;
                    break;
                default:
                    selection = 0;
                    break;
            }

            break;  
        }
    }
    return selection;
}

double GetHours()
{
    double deger = 0;
    bool dogruDeger = false;
    while (!dogruDeger) // true olduğu sürece dönüyor eğer double çevirme işlemi gerçekelşirse false olup döngüyü yani sayı gir diye sormayı bırakıyor 
    {
        string girilenDeger = Console.ReadLine();

        if (double.TryParse(girilenDeger, out deger))
        {
            dogruDeger = true;
        }
        else
        {
            Console.WriteLine("Hatalı giriş! Lütfen bir sayı girin.");
        }
        Console.ReadLine();
    }
    return deger;
}

double CalculateParkingPrice(int selection, double parkingtime)
{
    
    double ceelingvalue = Math.Ceiling(parkingtime);// 2.2 ise bir üste yuvarlıyor 
    
    if (selection == 1)
    {
        
        if (ceelingvalue > 0 && ceelingvalue < 2)
        {
            double price = 5;
            return price;
        }
        if (ceelingvalue > 2 && ceelingvalue < 6)
        {
            double price = 10;
            return price;
        }
        if (ceelingvalue > 6 && ceelingvalue < 12)
        {
            double price = 20;
            return price;
        }
        if (ceelingvalue > 12 && ceelingvalue < 24)
        {
            double price = 35;
            return price;
        }

        if (ceelingvalue > 24)
        {
            int totaldays = (int)(ceelingvalue/24);
            double price = 35 + (totaldays * 20);
            //double price = (ceelingvalue / maxhours) *20;
            return price;
        }
    }
    return 1;
   
   
    //else if (selection == 2)
    //{

    //}
    //else if (selection == 3)
    //{

    //}
    //else if (selection == 4)
    //{

    //}

}