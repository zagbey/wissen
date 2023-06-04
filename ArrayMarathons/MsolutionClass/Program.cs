/*Bir integer dizisindeki elemanlardan yalnızca 5'e bölünebilenleri yeni bir diziye kopyalayın.
 * İşlem sonunda elemanları - aynı indexteki değerler yan yana gelecek şekilde - alt alta yazdırın*/

Random random = new Random();
int[] ints = new int[40];

int index = 0;
while (index < ints.Length)
{
    ints[index] = random.Next(1,101); //1 ile 100 arası sayı üretip dizinin indexinci elemanına atıyor 
    index++;
}

int[] copyints = new int[0];

for (int i = 0; i < ints.Length; i++)
{
    if (ints[i] %5 == 0)
    {
        Array.Resize(ref copyints, ints.Length + 1);
        copyints[copyints.Length - 1] = ints[i];
    }
}
Array.Sort(copyints);

for (int counter = 0;counter < ints.Length; counter++)
{
    Console.Write("[{0}]",counter.ToString().PadRight(4));
    Console.Write(ints[counter].ToString().PadRight(20));

    if (counter < copyints.Length)
    {
        Console.Write(copyints[counter]);
    }
    Console.WriteLine();
}