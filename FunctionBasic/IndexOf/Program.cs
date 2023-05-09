//3.IndexOf
// Bir string'te bir karakterin kaçıncı index'te yer aldığını tespit edip
// döndüren bir fonksiyon yazın. Eğer aranan karakter string'te yer almıyorsa
// fonksiyonun -1 değeri döndürmesi gerekir

Console.WriteLine("bir isim giriniz");
string name = Console.ReadLine();
Console.WriteLine("aramak istediğiniz harfi girin");
string name2= Console.ReadLine();
char search =Convert.ToChar(name2);

int ındexOf = IndexOf(name, search);
Console.WriteLine("Aranan karakter {0}.indexte", ındexOf);

int IndexOf(string name, char search)
{
    for (int i = 0; i < name.Length; i++)
    {
        if (name[i] == search)
        {
            return i;
        }

    }
    return -1;
}