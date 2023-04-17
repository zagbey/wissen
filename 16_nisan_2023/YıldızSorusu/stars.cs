/*
 *  *
 *   * 
 *    *
 *     *
 *      *
 * */ // ekrana böyle bunu çizdirin 

int row = 0; // satır sayacı, döngü her çalıştığında 1 artırılacak
while (row < 5) // 5 satıra kadar döngü devam edecek
{
    int col = 0; // sütun sayacı, her satırda 0'dan başlayacak
    while (col < row) // sütun sayacı, satır sayacına eşit olana kadar artacak
    {
        Console.Write(" "); // sütun sayısı kadar boşluk yazdır
        col++; // sütun sayacını artır
    }
    Console.WriteLine("*"); // satırın sonuna yıldız yazdır
    row++; // satır sayacını artır
}

    