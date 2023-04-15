//1 ile 500 arası 7 ye bölünebilen sayıların adedi // CTRL+R+R bul değiştir 
int sayac = 1;
int adet  = 0;
while (sayac <= 500)
{
    if (sayac %7 == 0)
    {
        adet++;
    }
    sayac++;
}
Console.WriteLine("1 ila 500 arasında 7'ye tam bölünenlerin sayısı: " + adet);