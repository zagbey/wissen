/*         *
          *
         *
        *    şekil1.1
 */


// satir ve sutun değişkenleri kullanılarak yıldız şekli oluşturulacak
int satir = 1;

// 4 satır ve 4 sütundan oluşan yıldız şekli çiziliyor
while (satir <= 4)
{
    // sutun değişkeni, her satırda kaç yıldızın çizileceğini belirler
    int sutun = 1;
    while (sutun <= 4)
    {
        // yıldızın çizilip çizilmeyeceği kontrol ediliyor
        if (sutun == 5 - satir)
        {
            // yıldız yazdırılıyor
            Console.Write("*");
        }
        else
        {
            // nokta yazdırılıyor
            Console.Write(" ");
        }

        // sutun değişkeni artırılıyor
        sutun++;
    }

    // bir sonraki satıra geçiliyor
    Console.WriteLine();

    // satir değişkeni artırılıyor
    satir++;
}
