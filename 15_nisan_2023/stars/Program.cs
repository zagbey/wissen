/*
            *
          * *
        * * *
      * * * *
    * * * * *
 */


int rowCounter = 0;
int starLimit = 1;

while (rowCounter < 5)
{
    // Daha önceki çözümlerde adı starCounter olan
    // yıldız karakteri sayacının adını bu çözümde
    // charCounter olarak değiştirdim

    // Çünkü artık bu değişken hem boşlukları hem de
    // yıldız karakterlerini ekrana yazdıkça sayıyor
    // Sadece ekrana yazdığım yıldızları saymıyor
    int charCounter = 0;

    while (charCounter < 5)
    {
        // 5 - starLimit her adımda kaç adet
        // boşluk karakteri yazmam gerektiğini söylüyor
        // ilk adımda starLimit -> 1
        // 5 - 1 => 4 boşluk karakteri
        if (charCounter < 5 - starLimit)
        {
            Console.Write("  ");
        }
        else
        {
            Console.Write("* ");
        }

        charCounter++;
    }

    starLimit++;

    Console.Write("\n");

    rowCounter++;
}