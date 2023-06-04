

char continueControl = 'E';

do
{
    PrintMenu();
    int hardness = GetHardnessSelection();
    int number = GenerateRandomNumber(hardness);
    int tryCount = PlayGame(number, hardness);

    if (tryCount > 0)
    {
        int point = CalculatePoint(tryCount);
        DisplayResult(tryCount, point);
        continueControl = CheckContinue();
    }
    else if (tryCount == -1)
    {
        break;
    }
    else if (tryCount == -2)
    {

    }

} while (char.ToUpper(continueControl) == 'E');


void PrintMenu()
{
    Console.Clear();
    Console.WriteLine("Lütfen aşağıdaki zorluk seviyelerinden birisini seçiniz:");
    Console.WriteLine("1. Kolay seviye için 1'i tuşlayın");
    Console.WriteLine("2. Orta seviye için 2'i tuşlayın");
    Console.WriteLine("3. Zor seviye için 3'i tuşlayın");
}

int GetHardnessSelection()
{
    int hardness = 0;

    while (hardness == 0)
    {
        ConsoleKeyInfo keyInfo = Console.ReadKey(true);

        if (keyInfo.KeyChar != '1' && keyInfo.KeyChar != '2' && keyInfo.KeyChar != '3')
        {
            Console.Write('\b');
            Console.WriteLine("Hatalı bir giriş yaptınız, tekrar deneyin");
            continue;
        }

        switch (keyInfo.KeyChar)
        {
            case '1':
                hardness = 1;
                break;
            case '2':
                hardness = 2;
                break;
            case '3':
                hardness = 3;
                break;
            default:
                throw new InvalidOperationException();
        }
    }

    return hardness;
}

int GenerateRandomNumber(int level)
{
    Random random = new Random();

    switch (level)
    {
        case 1:
            return random.Next(1, 11);
        case 2:
            return random.Next(1, 101);
        case 3:
            return random.Next(1, 1001);
        default:
            return random.Next(1, 11);
    }
}

int PlayGame(int number, int hardness)
{
    int tryCount = 0;

    int prediction;
    int prevPrediction = -1;

    do
    {
        Console.Write("Tahmininizi yazın: ");
        string input = Console.ReadLine();

        if (input.StartsWith("cl"))
        {
            return -2;
        }
        else if (input == "exit")
        {
            return -1;
        }


        int.TryParse(input, out prediction);

        if (prediction != number)
        {
            int difference = Math.Abs(number - prediction);

            double rate = difference / Math.Pow(10, hardness);

            if (rate <= 0.1)
            {
                Console.Write("Sıcak");
            }
            else if (rate <= 0.25)
            {
                Console.Write("Ilık");
            }
            else
            {
                Console.Write("Soğuk");
            }

            if (prevPrediction >= 0)
            {
                int prevDifference = Math.Abs(prevPrediction - number);

                if (prevDifference < difference)
                {
                    Console.Write(", uzaklaştın..");
                }
                else if (prevDifference > difference)
                {
                    Console.Write(", yaklaştın..");
                }
                else
                {
                    Console.Write(", bir arpa boyu büyümedin");
                }
            }

            Console.WriteLine();

            prevPrediction = prediction;
        }

        tryCount++;
    } while (prediction != number);

    Console.WriteLine("Tebrikler!! Bildiniz");

    return tryCount;
}

int CalculatePoint(int tryCount)
{
    double pointDouble = 1000;
    while (tryCount > 1)
    {
        pointDouble /= 1.1;

        tryCount--;
    }

    return (int)Math.Ceiling(pointDouble);
}

void DisplayResult(int tryCount, int point)
{
    Console.WriteLine("{0} denemede toplam {1} puan kazandınız!", tryCount, point);
}

char CheckContinue()
{
    Console.WriteLine("Oyun bitti");
    Console.WriteLine("Tekrar oynamak istiyor musunuz? (E/H)");

    ConsoleKeyInfo keyInfo;
    do
    {
        keyInfo = Console.ReadKey(true);

    } while (char.ToUpper(keyInfo.KeyChar) != 'E' &&
             char.ToUpper(keyInfo.KeyChar) != 'H');

    return keyInfo.KeyChar;
}