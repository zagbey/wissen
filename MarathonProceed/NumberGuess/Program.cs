//Oyunun 3 zorluk seviyesi vardır. Zorluk seviyeleri oyunun açılışında kullanıcıya sunulur ve kullanıcı 1, 2
//veya 3 olarak ifade edilen zorluk seviyesini seçer.

void PrintMenüSelection()
{
    Console.WriteLine("Lütfen aşağıdaki zorluk seviyelerinden birisini seçiniz:");
    Console.WriteLine("1. Kolay seviye için 1'i tuşlayın" +
        "\r\n2. Orta seviye için 2'i tuşlayın" +
        "\r\n3. Zor seviye için 3'i tuşlayın");
}


PrintMenüSelection();
int selection = GetGameLevelSelection();
int secretnumber = RandomNumber(selection);
Console.WriteLine();
Console.WriteLine("bir sayı tahmininde bulunun");
GuesNumber(secretnumber);

void GuesNumber(int secretnumber)
{
    int guescount = 0;
    string input = Console.ReadLine();


    while (!int.TryParse(input, out int number))
    {
        guescount++;
        Console.WriteLine("Lütfen \"SAYI\" girişi yapınız");
        Console.WriteLine();


        input = Console.ReadLine();

        if (number == secretnumber)
        {
            Console.WriteLine("tebrikler ! {0} doğru tahmin", number);
            Console.WriteLine("{0}. tahminde doğru cevabı buldunuz", guescount);
        }
        break;
    }

}
int GetGameLevelSelection()
{

    while (true)
    {
        ConsoleKeyInfo keyInfo = Console.ReadKey();

        if (keyInfo.KeyChar != '1' &&
            keyInfo.KeyChar != '2' &&
            keyInfo.KeyChar != '3')
        {
            Console.Write('\b');
            Console.WriteLine("Hatalı bir giriş yaptınız, lütfen tekrar deneyin");
            continue;
        }


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
                throw new InvalidOperationException();
        }

        break;

    }
    return selection;

}

int RandomNumber(int selection)
{
    Random random = new Random();
    int number;

    if (selection == 1)
    {
        number = random.Next(0, 11);
        return number;
    }
    else if (selection == 2)
    {
        number = random.Next(0, 101);
        return number;
    }
    else if (selection == 3)
    {
        number = random.Next(0, 1001);
        return number;
    }
    else
    {
        throw new InvalidOperationException();
    }

}


