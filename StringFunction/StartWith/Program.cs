// Bir string bir karakter ile veya başka bir string ifade ile başlar mı başlamaz mı
// sorusunun cevabını verir

// Tsubasa T ile başladığı için true döndürecek



// starwith 

string text = "Taro Misaki";

char aLetter = 'a';

bool contains = false;
// bool contains =text.Contains(aLetter);

int index = 0;

while (index < text.Length)
{
    if (text[0] == aLetter)
    {
        contains = true;
        Console.WriteLine("{0} stringi {1} KARATERİ ile başlıyor ", text, aLetter);
        break;
    }
    else
    {
        Console.WriteLine("{0} stringi {1} KARATERİ ile başlamıyor", text, aLetter);
        contains = false;
        break;
    }

}
Console.WriteLine("*******************************************************");

// stirng ifadede sting kısım arama 

Console.Write("Lütfen bir kelime girin: ");
string word = Console.ReadLine();

Console.Write("Lütfen kontrol edilecek ifadeyi girin: ");
string wordControl = Console.ReadLine();

bool control = true;
int i = 0;

while (i < wordControl.Length && i < word.Length)
{
    if (wordControl[i] != word[i])
    {
        control = false;
        break;
    }
    i++;
}

if (control && wordControl.Length <= word.Length)
{
    Console.WriteLine("{0} ifadesi {1} kelimesiyle başlıyor.", word, wordControl);
}
else
{
    Console.WriteLine("{0} ifadesi {1} kelimesiyle başlamıyor.", word, wordControl);
}

Console.ReadKey();