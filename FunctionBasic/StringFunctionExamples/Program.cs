// 1. ReverseString
// Parametreden gönderdiğimiz string bir argümanı ters çevirip
// döndüren fonksiyonu yazın

string reversedString = ReverseString("Tsubasa");

Console.WriteLine(reversedString);

int[] reversedArray = ReverseArray(new int[] { 1, 2, 3, 4, 5 });

// Dizileri bu şekilde Konsol ekranına yazdıramam
// döngü yardımıyla tek tek yazdırmam gerekir
Console.WriteLine(reversedArray);

for (int i = 0; i < reversedArray.Length; i++)
{
    Console.WriteLine(reversedArray[i]);
}

string ReverseString(string value)
{
    string reversed = string.Empty;

    for (int i = value.Length - 1; i >= 0; i--)
    {
        reversed += value[i]; // asab
    }

    return reversed;
}

// 2. ReverseArray
// Bir integer dizisindeki elemanları ters çevirip döndüren fonksiyon
//burada bir tane dizi tanımlama lazım 
//reverseArray Sorusunda çözüldü 
int[] array = new int[]
{
    1,2, 3, 4,5, 6, 7, 8, 9, 10, 11, 12, 13, 14
};

for(int i = 0; i < array.Length; i++)
{
    Console.WriteLine($"{array[i]}");
}



int[] ReverseArray(int[] array)
{
    int[] reversedArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        reversedArray[reversedArray.Length - 1] = array[i];
    }
    return reversedArray;
}

// 3. IndexOf
// Bir string'te bir karakterin kaçıncı index'te yer aldığını tespit edip
// döndüren bir fonksiyon yazın. Eğer aranan karakter string'te yer almıyorsa
// fonksiyonun -1 değeri döndürmesi gerekir

// 3. SubString
// Bir string ifadeden istenen bir bölümü kopyalayıp döndüren fonksiyon