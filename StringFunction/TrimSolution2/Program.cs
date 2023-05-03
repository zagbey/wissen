/* 
* Trim fonksiyonu kullanmadan bir metnin çevresindeki boşlukları silen program
*/
//             12       123     123
string text = "  Tsubasa   Ozora   ";
// "Tsubasa   Ozora"

string trimmed = ""; // empty string

// metnin tek tek karakterlerine eriştiğimiz index sayacı
int index = 0;

// metni tek tek dolaşırken tespit ettiğimiz boşlukları sayan değişken
int spaceCounter = 0;

// index, tüm metnin (boşluklar dahil) boyutundan küçük olduğu sürece
// döngü devam etsin
while (index < text.Length)
{
    // Eğer index'inci karakter boşluk karakteri değilse
    // Eğer index'in değeri 3 ise text[3] -> s harfine denk gelir
    if (text[index] != ' ')
    {
        // Eğer trimmed değişkeninde şu ana kadar karakterler biriktiyse
        // trimmed string'i artık boş string değildir
        // Bununla birlikte şu an tüm ifadede ikinci veya üçüncü kelimeye
        // eriştiğimizi anlıyoruz
        if (trimmed != "")
        {
            // Metnin en başında olmadığım için (Ozora'nın O harfinde olduğumuzu düşünün)
            // trimmed'e spaceCounter adedi kadar boşluk eklemem gerekir
            while (spaceCounter > 0)
            {
                // trimmed ifadesine boşluk ekle
                trimmed += ' ';

                // boşluk sayacını eksilt
                spaceCounter--;
            }
        }
        else
        {
            spaceCounter = 0;
        }

        // trimmed -> "Tsubasa   "
        trimmed = trimmed + text[index];
    }
    else
    {
        // Eğer text'in index'inci karakteri boşluk ise bunu say
        // Saydırdığımız boşlukları yukarıdaki if bloğunda ihtiyaç durumunda
        // tekrar metne eklemem gerekebilir
        // Bkz. 32. satır
        spaceCounter++;
        // boşluk say
    }

    index++;
}

Console.WriteLine("Orijinal değer: '{0}'", text);
Console.WriteLine("Trimlenen: '{0}'", trimmed);