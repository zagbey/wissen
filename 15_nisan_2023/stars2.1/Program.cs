/*
 *   *
 *   **
 *   ***
 *   ****
 *   *****
 *   ******
 *   *******
 *   ********
 *   
 * */

int rowCounter = 0;

while (rowCounter < 8)
{
    int colum = 0;
    while (colum < rowCounter)
    {
        Console.Write("*");
        colum++;
    }
    Console.WriteLine();
    rowCounter++;

}