/* 
* Trim fonksiyonu kullanmadan bir metnin çevresindeki boşlukları silen program
*/
//             0 2             16 19
string text = "  Tsubasa   Ozora   ";
// "Tsubasa   Ozora"

int startIndex = 0;
while (startIndex < text.Length)
{
    if (text[startIndex] != ' ')
        break;

    startIndex++;
}

// startIndex -> 2

int endIndex = text.Length - 1;
while (endIndex >= 0)
{
    if (text[endIndex] != ' ')
        break;

    endIndex--;
}

// endIndex -> 16

string trimmed = "";
while (startIndex <= endIndex)
{
    trimmed += text[startIndex];
    startIndex++;
}

// Ters bölü/slash karakteri -> Escape char, kaçış karakteri anlamına gelir
// String ifadeler içerisinde özel karakterleri yazdırmak için kullanılır
// Örneğin satır başı için \n
// Tab karakteri için \t
// Tırnak karakterini string içerisinde yazdırmak için \"
Console.WriteLine("Orijinal değer: \"{0}\"", text);
Console.WriteLine("Trimlenen ifade: \"{0}\"", trimmed);