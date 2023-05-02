// containsin çalışma mantığı 

string text = "Taro Misaki";

char aLetter = 'a';

bool contains = false;
// bool contains =text.Contains(aLetter);

int index = 0;

while(index < text.Length)
{
    if (text[index] == aLetter)
    {
        contains = true;
        break;
    }
    index++;
}
Console.WriteLine("{0} stringi {1} KARATERİNİ içerir mi ? : {2}",text,aLetter,contains);