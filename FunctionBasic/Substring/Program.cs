//// 3. SubString
//// Bir string ifadeden istenen bir bölümü kopyalayıp döndüren fonksiyon

//string name = "Zeynel Abidin Gencer";

//string copypart = "Abidin";

//int index = 0;
////int copyindex = 0;
//string value=string.Empty;
//for (int i = index; index<name.Length; index++)
//{
//    if (name[index] == copypart[index])
//    {
//        value += index;
//    }
//    Console.Write(value);
//}
string name = "Zeynel abidin gencer";
string search = "abidin";

string resultfinal = CopySubstring(name, search);
Console.WriteLine(resultfinal);

string CopySubstring(string str, string searchText)
{
    int startIndex = str.IndexOf(searchText); // Aranan ifadenin başlangıç pozisyonunu alıyoruz.
    int length = searchText.Length; // Aranan ifadenin uzunluğunu alıyoruz.

    if (startIndex == -1 || length <= 0 || startIndex + length > name.Length) // Eğer aranan ifade metinde yoksa, null değer döndürüyoruz.
    {
        throw new ArgumentOutOfRangeException();
    }


    char[] chars = new char[length];

    for (int i = 0; i < length; i++)
    {
        chars[i] = str[startIndex + i]; // Başlangıç pozisyonundan itibaren, uzunluk kadar karakteri karakter dizisine kopyalıyoruz.
    }

    string result = new string(chars); // Karakter dizisini yeni bir string ifadesine dönüştürüyoruz.

    return result; // Kopyalanan alt dizenin sonucunu döndürüyoruz.
}

