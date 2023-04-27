int MaxValue = int.MinValue;
int MinValue = int.MaxValue;
bool end = false;

while (!end)
{
    Console.WriteLine("bir sayı girin veya bitirmek için end yazın");
    string input = Console.ReadLine();

    if (input.ToLower() == "end")
    {
        end = true;
    }
    else
    {
        int number;
        bool success = int.TryParse(input, out number);
        if (success)
        {
            if (number > MaxValue)
            { MaxValue = number; }
            if (number < MinValue)
            { MinValue = number; }
        }
        else
        {
            Console.WriteLine("lüfen bir sayı giriniz ");
        }
    }
}

