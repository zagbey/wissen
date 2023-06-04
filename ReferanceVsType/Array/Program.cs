// ValueType
// Değer Tipli
int number = 10;
int copyNumber = number;
copyNumber = 50;

Console.WriteLine("copyNumber: {0}", copyNumber);
Console.WriteLine("number: {0}", number);

Console.WriteLine("\n------------------------\n");

// ReferenceType
// Referans Tipli
int[] array = new int[3]; // 0xABCD
array[0] = 10;
array[1] = 20;
array[2] = 30;

int[] copyArray = array;
copyArray[0] = 50;

Console.WriteLine("Kopyalanmış dizinin elemanları:");
for (int i = 0; i < copyArray.Length; i++)
{
    Console.WriteLine(copyArray[i]);
}

Console.WriteLine("\n--------------------------\n");

Console.WriteLine("Orijinal dizinin elemanları:");
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine(array[i]);
}

// Diziler referans tipli yapılar olduğu için int[] copyNumbers = numbers;
// ifadenin yer aldığı satırda copyNumbers değişkenine orijinal dizi olan
// numbers'ın değerlerini değil aslında kendisini/referansını kopyaladım

copyArray = new int[2]; // 0xBCDE
copyArray[0] = 300;
copyArray[1] = 500;


Console.WriteLine();
Console.WriteLine();

array = copyArray;
for (int i = 0; i < copyArray.Length; i++)
{
    Console.WriteLine(copyArray[i]);
}