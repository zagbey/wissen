/*string text = "Zeynel Abidin Gencer";
int index = 0;
string value = "";

string[] splittedValue = new string[0];

while (index < text.Length)
{
    //if (text[index] ==' ')
    if (char.IsWhiteSpace(text[index]))
    {
        Array.Resize(ref splittedValue, splittedValue.Length + 1);
        splittedValue[splittedValue.Length - 1] = value;
        value = "";
    }
    else
    {
        value += text[index];
    }
    index++;
}
if (value != "")
{
    Array.Resize(ref splittedValue, splittedValue.Length + 1);
    splittedValue[splittedValue.Length - 1] = value;
}
index = 0;
while (index < splittedValue.Length)
{
    Console.WriteLine(splittedValue[index]);
    index++;
}*/

string[] strings = new string[]
{
    "Tsubasa",
    "Misaki",
    "Hyuga",
    "Wakabayashi"
};
int index = 0;


string[] copystrings = new string[0];

while (index < strings.Length)
{
    if (strings[index] != "")
    {
        Array.Resize(ref copystrings, copystrings.Length + 1);
        copystrings[copystrings.Length - 1] = strings[index];
    }
    index++;

}
int counter = copystrings.Length - 1;
index = 0;
while (index < copystrings.Length)
{
    if (strings[index] == copystrings[index])
    {
        Console.Write("{0}\t", copystrings[index]);
    }
    Console.WriteLine("{0}", strings[index]);
    index++;
}