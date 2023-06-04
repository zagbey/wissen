//cATEGORY adında bir sınıf yazıyoruz
//sınıfta varsayılan bir adet constructor olcak 
//özellikler
//kategori adı 
//açıklaması 
//oluşturulma tarihi 

//kurallar 
//tüm propertyler full property olarak yazalım
//name property'si null değer set edilemesin ,null değer gönderildiğinde bulunu boş string olarak değiştir 

//creatDate değeri set edilirken eğer şu anın tarih/saat bilgisinden daha büyük bir değer 
//gönderilirse bunu kabul etmeyip DateTime.Now olarak bu tarihi set din

//Constructor içinde CreateDate şu anın tarih/saat bilgisi olarak atansın 

//program.cs tarafından 3 adet farklı category instance oluşturarak 
//bunların değerlerini ekrana yazdırıp test edin 

using OOPExample01;

Category category = new Category();
DateTime date = new DateTime();

category.Name = "Dram";
category.Description = "Nuri Bilge Ceylandan kalpleri parça pinçik eden gerçek bir hayat öyküsü";
category.CreatedDate = new DateTime(2054, 1, 15);
Console.WriteLine(category.CreatedDate);