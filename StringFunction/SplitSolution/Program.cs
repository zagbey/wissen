/*
* bir ifadeyi belirli bir karaktere göre bölüp, bölünmüş değerleri
* bir string dizisi olarak üreten program yazın
*/

string text = "Tsubasa forvet arkası oynar";
// value: "oynar"
/* 
 * splittedValues
 * 0:   "Tsubasa"
 * 1:   "forvet"
 * 2:   "arkası"
 */

int index = 0;
string value = "";
string[] splittedValues = new string[0];

while (index < text.Length)
{
    //if (text[index] == ' ')
    if (char.IsWhiteSpace(text[index]))
    {
        // text'in index'inci karakteri boşlukmuş
        Array.Resize(ref splittedValues, splittedValues.Length + 1);
        splittedValues[splittedValues.Length - 1] = value;
        value = "";
    }
    else
    {
        value += text[index];
    }

    index++;
}

if (value != "") // Eğer döngü tamamlandığında value'da biriken bir kelime varsa bunu da eklemem gerekiyor
{
    Array.Resize(ref splittedValues, splittedValues.Length + 1);
    splittedValues[splittedValues.Length - 1] = value;
}

index = 0;
while (index < splittedValues.Length)
{
    Console.WriteLine(splittedValues[index]);
    index++;
}