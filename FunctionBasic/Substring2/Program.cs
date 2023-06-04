

string mainString = "Bu bir örnek metindir.";
string subString = CopySubstring(mainString, 0, 5);
Console.WriteLine(subString);


string CopySubstring(string str, int startIndex, int length)
{
    char[] chars = new char[length];

    for (int i = 0; i < length; i++)
    {
        chars[i] = str[startIndex + i];
    }

    string result = new string(chars);
    return result;
}
