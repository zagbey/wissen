// sorum = işlem bittikten sonra exit yazana kadar programın devam etmesini istiyorum 
while (true)
{

    Console.WriteLine("bir kelime yazınız");
    string name = Console.ReadLine();
    Console.WriteLine("aranacak kelimeyi girin");
    string nameLast = Console.ReadLine();


    bool Control = true;

    int index = name.Length - 1;

    while (index < nameLast.Length && index > name.Length)
    {
        if (nameLast[index] != name[index])
        {
            Control = false;
            break;
        }
        index--;
    }

    if (Control && nameLast.Length <= name.Length)
    {
        Console.WriteLine("{0} İfadesi {1} kelimesiyle bitiyor.", name, nameLast);
    }
    else
    {
        Console.WriteLine("{0} İfadesi {1} kelimesiyle bitmiyor.", name, nameLast);
    }
   /* Console.WriteLine("Lütfen çıkmak için ('exit' yazın): ");
    string input = Console.ReadLine();

    if (input == "exit")
    {
        break;
    }
   */ // Burada kullanıcıdan alınan komutla ilgili işlemler yapabilirsiniz.
}



