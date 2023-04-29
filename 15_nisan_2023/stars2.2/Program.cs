

int rowCounter = 0;

int maxSpace = 1;

while (rowCounter < 5)
{
    int spaceCounter = 0;
    while (spaceCounter < 5)
    {
        if (spaceCounter < 5 - maxSpace)
        {
            Console.Write("  ");
            
        }
        else
        {
            Console.Write("* ");
        }
        spaceCounter++;
    }
    Console.WriteLine();
    maxSpace++;
    rowCounter++;
}