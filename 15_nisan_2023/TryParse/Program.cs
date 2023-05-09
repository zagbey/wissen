// input doğru olana kadar giriş yaptırıyor 

Console.WriteLine("Lütfen bir sayı yazınız");
string input = Console.ReadLine();

while (!int.TryParse(input, out int number))
{
    Console.WriteLine("Yanlış bir giriş yaptınız");
    Console.WriteLine();
    Console.WriteLine("Lütfen bir sayı yazınız");

    input = Console.ReadLine();
}