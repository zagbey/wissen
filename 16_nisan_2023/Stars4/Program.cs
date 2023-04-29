int maxStars = 1;
int maxSpaces = 5;

while (maxStars <9 )
{
    // Bir satırlık işlem başlıyor
    int counter = 0;
    int spaceCounter = 0;

    while (spaceCounter < maxSpaces)
    {
        Console.Write(" ");
        spaceCounter++;
    }

    while (counter < maxStars)
    {
        Console.Write("*");
        counter++;
    }
    // Bir satırlık işlem bitiyor


    Console.WriteLine();
    maxStars += 2;
    maxSpaces--;

}