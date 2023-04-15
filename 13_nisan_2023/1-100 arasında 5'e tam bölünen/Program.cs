//1 ile 100 arasında  5 e bölünen tam sayıların toplamı 
int sayac = 0;
int toplam = 0;

while (sayac <= 100)
{
    sayac++;
    if (sayac % 5==0)
    {
        toplam = sayac + toplam; // toplam+=sayac
        sayac++; 
    }
    Console.WriteLine(toplam);
}