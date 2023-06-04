// 2. ReverseArray
// Bir integer dizisindeki elemanları ters çevirip döndüren fonksiyon
//burada bir tane dizi tanımlama lazım 
int[] array = new int[]
{
    1,2, 3, 4,5, 6, 7, 8, 9, 10, 11, 12, 13, 14
};

int[]reversedArray =ReverseArray(array);


for(int i = 0 ; i < array.Length; i++)
{
    Console.Write(reversedArray[i]+" ");
}



int[] ReverseArray(int[] array)
{
    int[] reversedArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        reversedArray[i] = array[array.Length-i-1]; // elemanları tersten yazdırmaya yarıyor 
    }
    return reversedArray;
}

