int[] values = new int[]
{
    10,20,30,40,50,60,70,80,90,111526,2654123,26416512
};



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
