//INDEXOF FONKSİYONU ÇALIŞMA MANTIĞI 

string text = "zeynel abidn gencer ";

char letter = 'a';

int index = 0;
int indexOfLetter = -1;
while (index < text.Length)
{
    if (text[index] == letter)
    {
        indexOfLetter = index;
        break;
    }

}
index++;

