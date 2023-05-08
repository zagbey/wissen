string[] invalidChars = new string[] { "zeynel abidin gencer", "samsun", "tekkeköy" };

int index = 0;

while (index < invalidChars.Length)
{
    Console.WriteLine(invalidChars[index]);
    index++;
}

Console.WriteLine("***********************************************************************");



string[] invalidChars2 = new string[] { "zeynel abidin gencer", "samsun", "tekkeköy" };

int index2 = invalidChars2.Length - 1;

while (index2 >= 0)
{
    Console.WriteLine(invalidChars2[index2]);
    index2--;
}

Console.WriteLine("************************************************************************");

/*Dizi elemanlarını yan yana yazma
   Bir dizinin elemanlarını 45 – 928 – 78 – 4 – 1007 – 83 şeklinde yan yana yazdıran kodu geliştirin. Elemanlar arasında mutlaka bir ayraç karakter olmalıdır. İlk elemandan önce veya son elemandan sonra ekranda – (veya diğer bir ayraç) karakteri olmamalıdır.
*/

int[] Array = new int[] { 45, 928, 78, 4, 1007, 83 };

int index3 = 0;

while (index3 < Array.Length)
{
    if (index3 == 0 || index3 == Array.Length - 1)
    {
        Console.Write("{0}", Array[index3]);
    }
    else
    {
        Console.Write("-{0}-", Array[index3]);
    }
    index3++;
}

Console.WriteLine("************************************************************************");

/*d. Dizi elemanlarını yan yana ters sırada yazma
   Bir dizinin elemanlarını 83 - 1007 - 4 - 78 - 928 - 45 şeklinde, dizi elemanlarının ters sırasıyla yan yana yazdıran kodu geliştirin. Elemanlar arasında mutlaka bir ayraç karakter olmalıdır. İlk elemandan önce veya son elemandan sonra ekranda – (veya diğer bir ayraç) karakteri olmamalıdır.
*/

int[] Array2 = new int[] { 45, 928, 78, 4, 1007, 83 };

int index4 = Array2.Length - 1;

while (index4 >= 0)
{
    if (index4 == 0 || index4 == Array.Length - 1)
    {
        Console.Write("{0}", Array[index4]);
    }
    else
    {
        Console.Write("-{0}-", Array[index4]);
    }
    index4--;
}
/* e. Dizi elemanlarını iki kolonda yazdırma
   Dizi elemanlarını sırasıyla iki kolonda yazdıracak kodu geliştirin. Program çıktısında dizi elemanları aşağıdaki sıralamada ekrana getirilecektir.*/

int[] values = new int[]
{
    10,20,30,40,50,60,70,80,90
};

Console.Write("****1dizi2\t2.dizi*****");

int index5 = 0;
while (index5 < values.Length)
{
    if (index5 % 2 == 0)
    {
        Console.Write("{0}\t", values[index5]);
    }
    else
    {
        Console.WriteLine("{0}", values[index5]);
    }
    index5++;
}

/*f. Dizi elemanlarını üç kolonda ters sırada yazdırma
   Dizi elemanlarını ters sırada üç kolonda ekrana yazdıran kodu geliştirin. Program çıktısında dizi elemanları aşağıdaki sıralamada ekrana getirilecektir.
***3***	***2***	***1***
dizi[2]	dizi[1]	dizi[0]
dizi[5]	dizi[4]	dizi[3]
dizi[8]	dizi[7]	dizi[6]
		dizi[9]*/
