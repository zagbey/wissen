using System.Xml.Linq;
using System;

//T****** O****
//string name = "Tsubasa Ozora";


int index = 0;
/*
while (index < name.Length)
{
    if (index > 0 && name[index] != ' ' && name[index - 1] != ' ')
    {
        Console.Write('*');
    }
    else
    {
        Console.Write(name[index]);
    }

    index++;

    //FLAG YÖNTEMİ İLE ÇÖZÜMÜ 

    // FLAG ile bir sonraki adıma bilgi taşıyorum 
    //yıldız yerine karakterin kendisini yazdırabilir
    //boşluk karakterine geldiğimizde ekrana boşluk yazdırıp flag değişkenini
    //true olarak set ediliyor.Yani bir sonrai adımda * karakteri yerine 
   *///karakterin kendisi yazılabilir bilgisi ulaşıyor 
/* Console.WriteLine("\n**********************************\n");
 // T****** O****
 string name = "Tsubasa Ozora";
 bool flag = true;
 index = 0;
 while (index < name.Length)
 {
     if (name[index] == ' ')
     {
         Console.Write(name[index]);
         flag = true;
     }
     else if (flag)
     {
         Console.Write(name[index]);
         flag = false;
     }
     else
     {
         Console.Write('*');
     }

     index++;
 }*/

string name = "Zeynel Abidin Gencer";
bool flag = true;
index = 0;

while (index < name.Length)
{
    if (name[index] == ' ')
    {
        Console.Write(' ');
        flag = true;
    }

    else if (flag)
    {
        Console.Write(name[index]);
        flag = false; 
    }
    else
    {
        Console.Write("*");
    }
    
    index++; 
}
