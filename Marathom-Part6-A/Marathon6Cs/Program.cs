while (true)
{
    Console.Write("Lütfen birinci sayıyı girin: ");
    string input1 = Console.ReadLine();
    if (!int.TryParse(input1, out int number1))
    {
        Console.WriteLine("Girdiğiniz değer geçersiz. Lütfen bir sayı girin.");
        continue;
    }

    Console.Write("Lütfen ikinci sayıyı girin: ");
    string input2 = Console.ReadLine();
    if (!int.TryParse(input2, out int number2))
    {
        Console.WriteLine("Girdiğiniz değer geçersiz. Lütfen bir sayı girin.");
        continue;
    }

    int start = Math.Min(number1, number2);// Math.Max’de olduğu gibi aynı şekilde işlemleri gerçekleştirirken bu sefer en küçük değeri geri döndürür.
    int end = Math.Max(number1, number2); //  Alacağı parametreler arasında sorgulama işlemi gerçekleştirerek sorgulanan değerlerden büyük değere sahip olanı geri döndürür.

    Console.WriteLine("Sayı\tKaresi\tKüpü");
    for (int i = start; i <= end; i++)
    {
        int square = i * i;
        int cube = i * i * i;
        Console.WriteLine("{0}\t{1}\t{2}", i, square, cube);
    }

    Console.WriteLine("Devam etmek için herhangi bir tuşa, çıkmak için 'exit' yazın:");
    string input = Console.ReadLine();
    if (input.ToLower() == "exit")
    {
        break;
    }
    Console.Clear();
}