// Built-in String Functions
// Hazır string fonksiyonları hemen hemen tüm programlama dillerinde
// var olan, işleri hızlandıran basit fonksiyonlar

string name = "Tsubasa";

// Contains -> İçerir mi?
bool contains = name.Contains('s');
Console.WriteLine("{0} ifadesi s harfini içerir mi? {1}", name, contains);

string emailAddress = "tsubasa@ozora.com";
if (emailAddress.Contains('ğ') ||
    emailAddress.Contains('Ğ') ||
    emailAddress.Contains('ş') ||
    emailAddress.Contains('ö'))
{
    Console.WriteLine("Geçersiz eposta adresi");
}

// IndexOf
// Bir string ifadede aranılan bir karakterin veya bir string'in kaçıncı index'te
// görüldüğünü döndüren fonksiyon
int indexOfS = name.IndexOf('s'); // bu fonksiyon çağırıldığında sonuç 1 olacak
int lastIndexOfS = name.LastIndexOf('s'); // Bu fonksiyonu çağırdığımda sonuç 5 olacak

int indexOfX = name.IndexOf('x'); // -1 döndürür

Console.WriteLine("{0} string'i içerisinde s harfi {1} index'inde görüldü", name, indexOfS);

// Overload: Aynı isimdeki fonksiyonun farklı parametrelerle yazılmış hali
// (diğer versiyonu)
// IndexOf fonksiyonunu 's' argümanıyla tek bir karakterle çağırabildiğim gibi
// "sub" argümanıyla bir string ifade için de çağırabilirim
int indexOfSub = name.IndexOf("sub");


// IndexOfAny
// Parametre olarak gönderdiğimiz char dizisindeki karakterlerden herhangi birisi
// tespit edildiği anda tespit edilen o karakterin index değerini döndürür
emailAddress = "cılgınGenç365@hotmail.com";
char[] invalidChars = new char[] { 'ğ', 'ş', 'ö', 'ç', 'ü', 'ı' };
int indexOfAny = emailAddress.IndexOfAny(invalidChars);

if (indexOfAny > -1)
{
    Console.WriteLine("E-posta adresiniz geçersiz bir karakter içerir");
    Console.WriteLine("Tespit edilen geçersiz karakter: {0}", emailAddress[indexOfAny]);
}


// StartsWith
// Bir string bir karakter ile veya başka bir string ifade ile başlar mı başlamaz mı
// sorusunun cevabını verir
bool startsWithT = name.StartsWith('T');
// Tsubasa T ile başladığı için true döndürecek

// EndsWith
bool endsWithE = name.EndsWith('e');
// Tsubasa e ile bitmediği için false döndürecek


// Replace
// Bul ve değiştir
// Bir string içerisinde argüman olarak gönderilen ifadeyi ikinci argüman olarak
// gönderilen başka bir ifadeyle değiştirir
string newName = name.Replace('T', 'M');
// Replace fonksiyonu istenen değişikliği name değişkeni üzerinde yapmaz
// yapılan değişikliği yeni bir değer olarak döndürür
// newName -> Msubasa
// name -> Tsubasa (orijinal değişken değişmez)

newName = name.Replace("Tsu", "Masu");
// newName -> Masubasa
// name -> Tsubasa

// Replace gördüğü tüm değerleri değiştirir
newName = name.Replace('a', 'u');
// newName -> Tsubusu
// name -> Tsubasa


// Substring
// Bir string ifadeden istenen bölümü kopyalayıp alan fonksiyon
string personInfo = "37482947433 Tsubasa Ozora";

// Örneğin; tek bir string ifadede kişi bilgisi olarak önce TC Kimlik no sonra da
// adı soyadı yazıyorsa, SubString ile TC Kimlik numaraları alınıp başka bir
// değişkene atılabilir
string tcKimlikNo = personInfo.Substring(0, 11);

// Remove
// Bir string'ten istenen bir index'ten itibaren istenen sayıda karakterin silinip
// yeni bir string olarak döndürülmesini sağlar
string nameSurname = personInfo.Remove(0, 12);



// PadLeft
// Bir string'in sol tarafına istenen karakteri istenen sayıda ekleyen fonksiyon
string iskiMembershipNo = "29347";

// Örneğin İSKİ faturası öderken abonelik numarası 8 haneye tamamlanması istenir
// Tüm abonelik numarası 8 hane olacak şekilde genellikle başına 0 sayısı eklenir
string validMembershipNo = iskiMembershipNo.PadLeft(8, '0');
// sonuç 00029347 olacak

// PadRight
// Yukarıdaki fonksiyonun aynısının sağ tarafa tamamlayanı


// ToLower, ToUpper
string lowerCaseName = name.ToLower();
// tsubasa ozora

string upperCaseName = name.ToUpper();
// TSUBASA OZORA


// Trim
// Bir string'in çevresindeki (sağındaki ve solundaki) boşlukları temizler
name = "        Tsubasa   Ozora     ";
string trimmedName = name.Trim(); // Sonuç "Tsubasa   Ozora"


// Split
personInfo = "37482947433  Tsubasa Ozora";
string[] values = personInfo.Split(' ');
/*
 * 0: "37482947433"
 * 1: ""
 * 2: "Tsubasa"
 * 3: "Ozora"
 */

string text = "saat kaç";
string[] splittedValue = text.Split('a');
/*
 * 0: "s"
 * 1: ""      -> empty string
 * 2: "t k"
 * 3: "ç"
 */

string emptyString = "";

// Bir string içerisinde kaç adet falanca karakterinin olduğunu sayan program
// Eposta adresinde geçersiz karakterleri tespit eden program

