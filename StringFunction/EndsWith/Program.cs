// containsin 
Console.
string str = "Merhaba dünya!";
char[] str2 = "a";


bool endsWith = false;


int index = 0;
while (index < str.Length)
{
    if (str[0] == str2)
    {
        endsWith = true;
    }

    index++;
}
//bir string'in başka bir string ifadeyle başlayıp başlamadığına bakan program

