/*    *
     **
    ***
   ****
*/



int row = 1;
while (row <= 4) // 4 satır oluşturmak için
{
    int column = 1;
    while (column <= 4 - row) // boşlukları sağlamak için
    {
        Console.Write(" ");
        column++;
    }

    int star = 1;
    while (star <= row) // yıldızları yazdırmak için
    {
        Console.Write("*");
        star++;
    }

    Console.WriteLine(); // her satırın sonunda bir alt satıra geçmek için
    row++;
}
