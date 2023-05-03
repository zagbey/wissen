/*
   Bir string'in belli bir string ile bitip bitmediği
   Örnek: "Genzo Wakabayashi" ifadesinin "ashi" ile bitip bitmediğinin kontrolü
*/


string text = "Genzo Wakayabashi";
string value = "ashi";

bool endsWith = true;

int textIndex = text.Length - 1; // 16
int valueIndex = value.Length - 1; // 3

while (valueIndex >= 0)
{
    // ilk adımda şuna bakmış oluyoruz
    // text[textIndex] != value[valueIndex]
    // text[16] != value[3]
    // 'i' != 'i'
    if (text[textIndex] != value[valueIndex])
    {
        endsWith = false;
        break;
    }

    textIndex--;
    valueIndex--;
}

Console.WriteLine("{0} metni {1} ifadesiyle mi biter? {2}", text, value, endsWith);
