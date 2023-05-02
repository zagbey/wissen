// Built - in String Function ----> hali hazırda var olan demek 
// hazır string fonksiyonları tüm programam dillerinde var olan işleri hızlandıran basit fonksiyonlardır.

string name = "Tsubasa";

//constain --> içerir mi demek 

bool constain = name.Contains("s");
Console.WriteLine("{0} ifadesi s harfi içerir mi ? {1}",name,constain);


string emailAdress = " tsubasaozara@gmail.com";

if(emailAdress.Contains("g") || emailAdress.Contains("ü"))
{
    Console.WriteLine("GEÇERSİZ HARF GİRDİNİZ");
}

//IndexOd 

//Bir string ifadede aranılan bir karakterin veya bir stringin kaçıncı indexte gmrüldüğünü gösteren fonskiyondur

int indexOfS = name.IndexOf("s"); // bu fonksiyon 1 olcaak 

int lastIndexOFs = name.LastIndexOf("s"); // sondan bakiyo cevap 5 

int indexOfX = name.LastIndexOf("x"); // sonuç -1 döner

Console.WriteLine("{0} String içerinde s harfi {1} indexinde görüldü", name, indexOfS);


emailAdress = "çılgınGenç365@gmail.com";
    char[] invalidChars = new char[] { 'ğ', 'ş', 'ö', 'ç', 'i' };
int indexofAny = emailAdress.IndexOfAny(invalidChars);

if (indexofAny == -1)
{
    Console.WriteLine("tespit edilen geçersin karakter : {0}", emailAdress[indexofAny]);
}

//starsWith-----> şu karakterle şu stringle başlıyor mu 

bool starsWitT = name.StartsWith('T');


//EndsWith------> şu karakterle bitiyor mu 

bool endsWithE = name.EndsWith("e");


//replace-------> bul ve değiştir gibi kullanılabilir 


string newName = name.Replace('T', 'M'); //DEĞİŞTİRİYOR AMA NAME(aranan string orjinal string) DEĞİŞMEZ DEĞİŞTİRİP YENİ STRING DEĞİŞKENE ATIYOR 

newName = name.Replace("Tsu", "Msu");; // bu şekilde string ifadekler de değişebilir 


//Substring 
// string ifadeden istenen bölümü alan fonksiyon 


string personInfo = "14315849926 Zeynel Abidin Gencer";

// örneğin kişi bilgisinde ilk tc no sonra adı soyadı yazıyorsa tc kimlik nolar alınıp başka bir değişkene atanabilir 

string tcKimlikNo = personInfo.Substring(0,11);

//remove 
//bir stringten istenden indexten itibaren istenen sayıya kadar siler ve bunu yeni string oalrak tutmanı ister 

string nameNew = name.Remove(0,11); 

//PadLeft--------> stringin soltarafına istenen karakteri istenen sayıda ekleme fonksiyonu 

string iskiMembershipNo = "25648955";

string newMemberShip = iskiMembershipNo.PadLeft(2, '0'); // soluna 2 tane sıfır koyuyor 

//ToLower----> 
string lowerCaseName = nameNew.ToLower();

//ToUpper---->
string UpperCaseName = nameNew.ToUpper();

//Trim-----> bir string çevresindeki sağındaki ve solundaki yani boşlukları siliyor 

string nameFİNAL = "   zeynel  abidin   ";

string trimname = nameFİNAL.Trim();

string person1Info = "14315849926 Zeynel Abidin Gencer";



//Split dizi döndürmeli bişey yapıyor // ortadan kaldırıyor ve string e dizi olarak atıyor 
string[] values = person1Info.Split(' ');
/*
 *  0 : 14315849926
 *  1 : zeynel 
 *  2 : abidin
 *  3 : gencer 
 *  /