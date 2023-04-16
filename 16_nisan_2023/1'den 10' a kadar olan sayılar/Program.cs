//1'den 10'a kadar olan sayıları aralarında - oalcak şekilde yan yana yazdırın 

int number = 0;

while (number <= 10)
{
    
    if (number != 10) // eşit değilse 
    {
        Console.Write(number + " - ");
    }
    else
    {
        Console.Write(number);
    }
    number++;
}
