Console.WriteLine("BİR İSİM GİRİNİZ");
string name = Console.ReadLine();
Console.WriteLine("CÜMLE BİTİŞİNDEARANACAK KELİMEYİ GİRİNİZ");
string searchname = Console.ReadLine();


int searchindex = searchname.Length - 1;
int nameindex = name.Length - 1;

bool endsWith = true;


while (searchindex >= 0)
{
    if (name[nameindex] != searchname[searchindex])
    {
        endsWith = false;
        break;

    }
    nameindex--;
    searchindex--;
}

if  (endsWith && searchname.Length <= name.Length)
{
    Console.WriteLine("{0} İFADESİ {1} İFADESİ İLE BİTMEKTEDİR.",name,searchname);
}
else
{
    Console.WriteLine("{0} İFADESİ {1} İFADESİ İLE BİTMEMEKTEDİR.", name, searchname);
}
