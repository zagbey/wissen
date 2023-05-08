/*f. Dizi elemanlarını üç kolonda ters sırada yazdırma
   Dizi elemanlarını ters sırada üç kolonda ekrana yazdıran kodu geliştirin. Program çıktısında dizi elemanları aşağıdaki sıralamada ekrana getirilecektir.
***3***	***2***	***1***
dizi[2]	dizi[1]	dizi[0]
dizi[5]	dizi[4]	dizi[3]
dizi[8]	dizi[7]	dizi[6]
			    dizi[9]*/

int[] ints = new int[]
{12,13, 14, 15, 16, 17, 18, 19, 20, 21 };

int index = 0;

while (index < ints.Length)
{
    if (ints.Length > index + 2)
    {
        Console.Write("[{0}]\t", ints[index + 2]);
    }
    if (ints.Length > index + 1)
    {
        Console.Write("[{0}]\t", ints[index + 1]);
    }
    Console.WriteLine("[{0}]", ints[index]);
    index += 3;


}