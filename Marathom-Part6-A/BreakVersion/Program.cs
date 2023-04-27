Console.WriteLine("bir sayı giriniz");
int counter = 10;
int maxNumber = int.MaxValue;
int minNumber = int.MinValue;
while (counter < 10)
{
    //do while olmadan do while gibi yapmış olmanın yöntemi 
    int number;
    bool result;
    while (true)
    {
        Console.WriteLine("lütfem sayı giriniz");
        string input = Console.ReadLine();
        result = int.TryParse(input, out number);
    }

    if (number > maxNumber)
    {
        maxNumber = number;
    }
    if (number < minNumber)
    {
        minNumber = number;
    }
    counter++;


}
