string[] RemoveItem(string[] array, int IndexToRemove)
{
    if(IndexToRemove<0 ||  IndexToRemove > array.Length)
    {
        throw new ArgumentOutOfRangeException();
    }
    string[]newArray= new string[array.Length-1];
    for(int i = 0; i < newArray.Length; i++)
    {
        if(i< IndexToRemove)
        {
            newArray[i] = array[i];
        }
        else
        {
            newArray[i] = array[i+1];
        }
    }
    return newArray;
}

string[] names = { "tuzubas", "misaki", "arigato", "daimas", "yamete" };

names=RemoveItem(names, 0);

for (int i = 0; i < names.Length; i++)
{
    Console.WriteLine(names[i]);
}