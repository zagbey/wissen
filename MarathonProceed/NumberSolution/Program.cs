Console.WriteLine("Lütfen bir sayı giriniz:");
string input = Console.ReadLine();
int number;
bool exit = false;

while (!exit)
{
    if (input == "exit")
    {
        exit = true;
        break;
    }
    while (!int.TryParse(input, out number))
    {
        Console.WriteLine("Hatalı formatta bir sayı girdiniz. Lütfen tekrar deneyin:");
        input = Console.ReadLine();
    }

    Console.WriteLine("************************");

    int placeValue = 1;
    for (int i = input.Length - 1; i >= 0; i--)
    {
        int numericValue = int.Parse(input[i].ToString()); //  Girişteki karakteri tamsayıya dönüştürür
        int product = numericValue * placeValue; //  Basamak değeriyle çarpma işlemi

        Console.WriteLine($"{numericValue} x {placeValue} = {product}");

        placeValue *= 10;
    }
    break; 
}
