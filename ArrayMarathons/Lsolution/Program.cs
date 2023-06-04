string[] strings = new string[]
{
    "Tsubasa",
    "Misaki",
    "Hyuga ",
    "Wakabayashi"
}; 

int index = 0;
string[] copystrings = new string[0];

while (index < strings.Length)
{
    Array.Resize(ref copystrings, copystrings.Length + 1);
    copystrings[copystrings.Length - 1] = strings[index];
    index++;
}

int counter = copystrings.Length - 1;
index = 0;
while (index < copystrings.Length)
{
    Console.Write("{0}\"{1}\"", index.ToString().PadRight(4), copystrings[index].PadRight(20));
    Console.WriteLine("\"{0}\"", strings[counter]);
    counter--;
    index++;
}

//string column = copystrings[index].PadRight
