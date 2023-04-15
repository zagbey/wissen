//1 ile 20 arasında 3 e tam bölünebilen sayılar

int counter = 1;
while (counter <= 20)
{
    if (counter % 3 == 0)
    {
        Console.WriteLine(counter); 
         
    }
    counter++;
}