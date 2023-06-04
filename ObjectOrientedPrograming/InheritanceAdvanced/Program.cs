//F12 yabınca "class" çıkıyorsa referans tiplidir 
using System.Collections;

﻿

int number1 = 100;
int number2 = 200;

int total = number1 + number2;

// Türetilmiş (miras almış) bir tipten bir değişken değerini, miras aldığım
// tipteki bir değişkene atayabilirim

object number1Object = number1; // BOXING
// BOXING: Değer tipli bir veriyi, referans tipli olan object tipine
// dönüştürmeye boxing denir


// object tipinden bir değişkene atanmış integer bir değer matematik
// işlemlerde kullanılamaz
//total = number1Object + number2;

// Bir değeri başka bir tipe CAST edebiliriz
// CAST etme işlemini sayısal tipler arasındaki dönüşüm işlemlerinde görmüştük

// CAST etme işlemini, object tipindeki bir değişkenin değerini ÖZÜNE döndürmek
// için de kullanabilirim
int num1 = (int)number1Object; // UNBOXING

int result = num1 + 500;

// object tipindeki bir değişkene herhangi bir tipteki değeri atayabiliyoruz

// number1Object değişkenine yukarıdaki satırların birinde int tipinde
// bir değer atamıştık. Daha sonra aşağıdaki gibi DateTime tipinde bir
// değeri aynı değişkene atamak mümkün
number1Object = DateTime.Now;

// Veya yine aşağıdaki gibi string tipte bir değeri aynı değişkene
// atamak mümkün
number1Object = "Tsubasa";

// aşağıdaki is ile yazılmış ifadenin meali
// number1Object değişkeninin tuttuğu değer int tipinde midir
if (number1Object is int)
{
    int castedNumber = (int)number1Object;
}
else if (number1Object is string)
{
    string name = (string)number1Object;
}

ArrayList arrayList = new ArrayList();
arrayList.Add(100);
arrayList.Add(200);
arrayList.Add(300);

for (int i = 0; i < arrayList.Count; i++)
{
    object item = arrayList[i];
    int number = (int)item;
    Console.WriteLine(number * number);
}


Method("Tsubasa");
Method(1000);
Method(true);

// Herhangi bir tipteki değerin object tipinden miras alması durumunu
// ihtiyaç olduğunda aşağıdaki gibi bir avantaja dönüştürebiliriz

// Eğer metot parametresi object olarak tanımlanırsa, bu metot herhangi bir
// tipten değer ile çağırılabilir

// Bu durum birtakım avantajlar sağladığı gibi dezavantajları da beraberinde
// getirir. (Zamanla daha da netleşecek)
void Method(object value)
{

}