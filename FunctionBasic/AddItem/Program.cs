int[] AddItem(int[] array, int newItem)
{
    int[] newArray = new int[array.Length + 1];

    for (int i = 0; i < array.Length; i++)
    {
        newArray[i] = array[i];
    }
    newArray[newArray.Length - 1] = newItem;
    return newArray;
}

int[] numberArray = { 10, 20, 30, 40, 50 };

numberArray=AddItem(numberArray, 100);

for (int i = 0; i < numberArray.Length; i++)
{
    Console.WriteLine(numberArray[i]);
}


