int i = 1;

while (i <= 5) // 1'den 5'e kadar olan satırları yazdırmak için dıştaki döngü
{
    int j = 1;
    while (j <= i) // Her satırda bir yıldız daha fazla yazdırmak için içteki döngü
    {
        Console.Write("*");
       j++;
    }
    Console.WriteLine();
    i++;
}