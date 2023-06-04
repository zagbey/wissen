
int[] print = { 1, 2, 3, 4, 5, 6 };

Yazdir(print, true);

void Yazdir(int[] Array, bool horizantal)
{
    if (horizantal)
    {
        // Yatay yazdırma
        for (int i = 0; i < Array.Length; i++)
        {
            Console.Write(Array[i] + " ");
        }
    }   
    else
    {
        // Dikey yazdırma
        for (int i = 0; i < Array.Length; i++)
        {
            Console.WriteLine(Array[i]);
        }
    }
}


//veya 

void PrintArray(int[] Array, bool isHorizantal)
{
    for(int i = 0; i < Array.Length; i++)
    {
        Console.WriteLine(Array[i]);
        if (isHorizantal)
        {
            Console.Write(' ');
        }
        else
        {
            Console.WriteLine('\n');
        }
    }
   
}


