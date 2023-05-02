// alt alta yazıran programı geliştirin 
// ters sırada alt alta yazdıran programı geliştirin 
// yan yana arada - karekteri olacak şekilde yazdırın 
//örenek z-e-y-n-e-l-a-b-i-d-i-n

//bonus ad ve soyad arasındaki boşluk yerine / karakteri yazdırın 
// örnek z-e-y-n-e-l / A-b-i-d-i-n


//1.soru
/*string name = "zeynel abidin";
int idex1 = 0;

while (idex1 > name.Length)
{
    Console.WriteLine(name[idex1]);
    idex1++;
}


//3. soru çözümü 



int index = 0;

while (index < name.Length)
{
    if (index > 0)
    {
        Console.Write("-");

    }
    Console.Write(name[index]);
    index++;
}
// örnek z-e-y-n-e-l / A-b-i-d-i-n cevabı 
Console.WriteLine("---------------------------------------------------------");
int index2 = 0;

while (index2 < name.Length)
{
    if (index2 > 0 && name[index2] != ' ' && name[index2 - 1] != ' ')
    {
        Console.Write("-");
    }
    if (name[index2] == ' ')
    {
        Console.Write("/");
    }
    else
    {
        Console.Write(name[index2]);
    }
}
index2++;*/

//soru bankaların havale yapraken kiş iadlarını gizlediği yöntemi geliştirin
// z***** a*****
//z**** a****
/*
using System;

string name = "zeynel abidin";
 
int counter  = 0;

while (counter < name.Length)
{
    if (counter == 0)
    {
        Console.Write(name[counter]);
    }

    else
    {
        Console.Write("*");
    }
    counter++;
}*/

string name1 = "zeynel abidin gencer ";

int counter1 = 0;

//z**** a**** sorusunun çözümü  

while (counter1 < name1.Length)
{
                            //kendinden önceki boşluk değilse anlamına geliyor 
    if (counter1 > 0 && name1[counter1] != ' ' && name1[counter1 - 1] != ' ')
    {
        Console.Write("*");
    }
    else
    {
        Console.Write(name1[counter1]);
    }
    counter1++;
}

