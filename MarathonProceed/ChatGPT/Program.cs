
int difficultyLevel = 0; // zorluk seviyesi
int maxNumber = 0; // seçilen zorluk seviyesine göre belirlenen maksimum sayı
int randomNumber = 0; // bilgisayarın ürettiği rastgele sayı
int guess = 0; // kullanıcının tahmini
int numGuesses = 0; // kullanıcının kaç tahminde bulunduğunu sayacak değişken
int score = 0; // puan




void PrintMenüSelection()
{
    Console.WriteLine("Lütfen aşağıdaki zorluk seviyelerinden birisini seçiniz:");
    Console.WriteLine("1. Kolay seviye için 1'i tuşlayın" +
        "\r\n2. Orta seviye için 2'i tuşlayın" +
        "\r\n3. Zor seviye için 3'i tuşlayın");
}
PrintMenüSelection();
while(guess != maxNumber)
{
    numGuesses = 0;
    score = 0;
    // zorluk seviyesi seçimi
    while (difficultyLevel < 1 || difficultyLevel > 3)
    {
        Console.Write("Zorluk seviyesi seçiniz (1-3): ");
        try
        {
            difficultyLevel = Convert.ToInt32(Console.ReadLine());
        }
        catch (FormatException)
        {
            Console.WriteLine("Hatalı giriş! Lütfen 1, 2 veya 3 giriniz.");
        }
    }

    switch (difficultyLevel)
    {
        case 1:
            maxNumber = 10;
            break;
        case 2:
            maxNumber = 100;
            break;
        case 3:
            maxNumber = 1000;
            break;
    }

    Random random = new Random();
    randomNumber = random.Next(1, maxNumber + 1);


    Console.WriteLine("1 ila {0} arasında bir sayı tahmininde bulunun", maxNumber);
    DateTime startime = DateTime.Now;
    string input = Console.ReadLine();
    while (!int.TryParse(input, out int gues))

    {
        numGuesses++;
        Console.WriteLine("Hatalı giriş! Lütfen bir sayı giriniz.");
        Console.WriteLine();
        Console.WriteLine("lütfen tekrar deneyiniz.");
        input = Console.ReadLine();

    }

    if (guess == randomNumber)
    {
        DateTime endTime = DateTime.Now; // bitiş zamanı 
        TimeSpan timeTaken = endTime - startime;// geçen sürenin hesabı
        score = 1000 - (int)timeTaken.TotalSeconds * 10;//puan hesaplama 
        int gametime = (int)timeTaken.TotalMinutes;
        Console.WriteLine("Tebrikler {0}. denemede doğru tahminde  buldun", numGuesses);
        Console.WriteLine("{0} zamanda oyunu tamamladın", numGuesses);
        Console.WriteLine("Puanınız {0} ", score);
        break;
    }
    else
    {
        if (Math.Abs(randomNumber - guess) <= 10)
        {
            Console.WriteLine("sıcak!");
        }
        else
        {
            Console.WriteLine("soğuk!");
        }
    }
}
    
