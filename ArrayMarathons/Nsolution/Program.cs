string[] players = new string[]
{
    "Tsubasa",
    "Misaki",
    "Hyuga",
    "Wakayabashi",
    "Sawada"
 
};
//çift değerler 
string[] evenIndexValues = new string[0];
//tek değerler 
string[] oddIndexValues = new string[0];

for(int i = 0;i<players.Length; i++)
{
    if (i % 2 == 0)
    {
        Array.Resize(ref evenIndexValues, evenIndexValues.Length + 1);
        evenIndexValues[evenIndexValues.Length-1] = players[i];
    }
    else
    {
        Array.Resize(ref oddIndexValues, oddIndexValues.Length + 1);
        oddIndexValues[oddIndexValues.Length - 1] = players[i];
    }
}

for(int i= 0; i < players.Length; i++)
{
    Console.Write("[{0}]\t",i);
    Console.Write(players[i].PadRight(20));

    if (i < evenIndexValues.Length)
    {
        Console.Write(evenIndexValues[i].PadRight(20));
    }
    if(i < oddIndexValues.Length)
    {
        Console.Write(oddIndexValues[i]);
    }
    Console.WriteLine();
}