string text = "Zeynel Abidin Gencer";
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
        value ="";
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
while(index < splittedValue.Length)
{
    Console.WriteLine(splittedValue[index]);
    index++;
}