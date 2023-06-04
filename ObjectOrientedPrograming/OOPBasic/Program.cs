using OOPBasic;

// Sınıf -> Tip
// Nesne -> O tipten oluşturulmuş değer (değerler bütünü, instance)

// Random -> SINIF
// Runtime'da (programın çalışma anında) new Random() sayesinde oluşan
// ve random değişkenine atanan yapıya da NESNE diyoruz

Random random = new Random();
random.Next();


// Peki nedir NYP, OOP
// Bir yazılımı geliştirirken kullandığımız verileri ve davranışları
// nesneler aracılığı ile yönetmek, kurgulamak

// Gerçek hayatın programlama kodlarına yansıtılması

// Eğer C#'ta Nesne yapıları olmasaydı, kişi bilgilerini içeren
// bir diziyi aşağıdaki şekilde virgüllerle ayrılmış değerler şeklinde
// oluşturabilirdik

string[] names =
{
    "2387628376,Tsubasa,Ozora",
    "2937834763,Taro,Misaki",
    "3487938749,Ken,Wakashimazu"
};

for (int i = 0; i < names.Length; i++)
{
    // personInfo'nun 3 elemanlı bir dizi olmasını bekliyorum
    // 0 -> TC Kimlik No
    // 1 -> Adı
    // 2 -> Soyadı
    string[] personInfo = names[i].Split(',');
}

Person person = new Person();
// Sınıf'tan new keyword'ü yardımıyla yeni bir
// NESNE örneği (instance) oluşturdum

person.LastName = "Ozora";
person.FirstName = "Tsubasa";
//person.IdentityNumber = -2497395434;
person.SetIdentityNumber(-2497395434);
person.Age = -30;

int age = person.Age;// bu nedir yav 

Console.WriteLine(
    "{0} - {1} {2}, {3} yaşında",
    person.GetIdentityNumber(),
    person.FirstName,
    person.LastName ,
    person.Age);

Console.WriteLine(person.Talk());
Console.WriteLine(person.Introduce());






///////////////////////////////////////////////
//Person person2 = person;
//person2.FirstName = "Taro";
//person2.LastName = "Misaki";

//Console.WriteLine(
//    "{0} - {1} {2}",
//    person.IdentityNumber,
//    person.FirstName,
//    person.LastName);