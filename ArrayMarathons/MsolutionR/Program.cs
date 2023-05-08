/*Bir integer dizisindeki elemanlardan yalnızca 5'e bölünebilenleri yeni bir diziye kopyalayın.
 * İşlem sonunda elemanları - aynı indexteki değerler yan yana gelecek şekilde - alt alta yazdırın*/

Random random = new Random();
int[] ints = new int[30];

int index = 0;
while (index < ints.Length)
{
    ints[index] = random.Next(1, 500);
    index++;
}

index = 0;

int[] copyints = new int[0];
while (index < ints.Length)
{
    if (ints[index] % 5 == 0)
    {
        Array.Resize(ref copyints, copyints.Length + 1);
        copyints[copyints.Length - 1] = ints[index];
    }
    index++;
}

index = 0;
Array.Sort(copyints);// eğer diziyi sıralamak istersek 
while (index < ints.Length)
{
    Console.Write("{0}\t {1}\t", index, ints[index]);
    if (index < copyints.Length)
    {
        Console.Write(copyints[index]);
    }
    Console.WriteLine();
    index++;
}