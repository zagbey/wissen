//Console.WriteLine("Lütfen bir sayı giriniz:");
//string input = Console.ReadLine();



//for (int i = 0; i < (input.Length/2); i++)
//{
//    for (int j = input.Length - 1; j < (input.Length / 2); j--)
//    {
//        if (input[j] == input[i])
//        {
//            Console.WriteLine("palindormdur");
//        }
//    }
//}
bool exit = false;
while (!exit)
{
    Console.Write("Bir metin girin/çıkmak için \"exit\" yazın: ");
    string metin = Convert.ToString(Console.ReadLine());
    if (metin.ToLower() == "exit")
    {
        Console.WriteLine("Program sonlandı");
        exit = true;
    }
    else
    {
        if (IsPalindrome(metin))
        {
            Console.WriteLine("Girilen metin bir palindromdur.");
        }
        else
        {
            Console.WriteLine("Girilen metin bir palindrom değildir.");
        }
    }

    Console.ReadLine();

}

bool IsPalindrome(string metin)
{
    metin = metin.ToLower(); // Metni küçük harflere dönüştürmek için

    int baslangic = 0;
    int bitis = metin.Length - 1;

    while (baslangic < bitis)
    {
        if (metin[baslangic] != metin[bitis])
        {
            return false;
        }

        baslangic++;
        bitis--;
    }

    return true;
}
