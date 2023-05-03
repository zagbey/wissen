//trim fonsiyonu anlatımı 

string name = "  zeynel abidin gencer  ";

int startindex = 0;

while (startindex < name.Length)
{
    if (name[startindex] != ' ')
    {
        break;
    }
    startindex++;
}

int endindex = name.Length - 1;

while (endindex >= 0)
{
    if (name[endindex] != ' ')
    {
        break;
    }
    endindex--;
}


string trimmed = "";

while (startindex <= endindex)
{
    trimmed = trimmed + name[startindex];
    startindex++;
}

Console.WriteLine("orijinal değer : \"{0}\"",name);
Console.WriteLine("trimmed değer : \"{0}\"", trimmed);