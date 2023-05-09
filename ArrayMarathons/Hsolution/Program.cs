/*int[] nubmers = new int[5];
string input;


int n = 0;
while (n < 5)
{

    Console.WriteLine("{0}.dizi elemanını yazınız", n);
    input = Console.ReadLine();
    int number = 0;
    if (int.TryParse(input, out number))
    {
        nubmers[n] = number;

    }
    else
    {
        Console.WriteLine("hatalı bir giriş yaptınız");
    }
    n++;
}
Console.WriteLine("*****************DİZİNİN ELEMANLARI************");
int i = 0;
while (i < nubmers.Length)
    
{
    Console.WriteLine("[{0}]", nubmers[i]);
    ++i;
*    BU KODBLOGU DOĞRU ÇALIŞIYOR FAKAN DÖNGÜ SIRASINDA YANLIŞ İŞLEM YAZILDIĞINDA BİR SONRAKİ ELEMANA ATLIYOR HOCANIN ÇÖZÜMÜNDE BİR SONRAKİ ELEMANA ATLAMIYOR */

string input;
int[] numbers = new int[5];

while (true)
{
    Console.WriteLine("1. sayıyı yazın");
    input = Console.ReadLine();
    if (int.TryParse(input, out int number))
    {
        numbers[0] = number;
        break;
    }
    else
    {
        Console.WriteLine("Hatalı bir giriş yaptınız");
    }
}

while (true)
{
    Console.WriteLine("2. sayıyı yazın");
    input = Console.ReadLine();
    if (int.TryParse(input, out int number))
    {
        numbers[1] = number;
        break;
    }
    else
    {
        Console.WriteLine("Hatalı bir giriş yaptınız");
    }
}

while (true)
{
    Console.WriteLine("3. sayıyı yazın");
    input = Console.ReadLine();
    if (int.TryParse(input, out int number))
    {
        numbers[2] = number;
        break;
    }
    else
    {
        Console.WriteLine("Hatalı bir giriş yaptınız");
    }
}