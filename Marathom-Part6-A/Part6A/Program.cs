/*a.Kullanıcıdan istenecek 10 adet sayının içerisinde en büyük ve en küçük olanları tespit edip ekrana sonucu yazan programı geliştirin. Kullanıcının yazdığı değerlerin sayı olup olmadığının kontrolü yapılmalıdır. Kullanıcı uygun formatta sayı yazmazsa (“Yirmibeş”, “üç”, “Muhittin”) uyarı döndürülecek ve girilen değer geçersiz sayılacaktır.
Programı geliştirirken minimum sayıda değişken kullanın, her giriş yapılan değer için değişken oluşturmayın. Ayrıca kodlamada dizi kullanılmayacaktır.
Program bir kez hesap yaptıktan sonra herhangi bir tuşa basıldığında sonlanacaktır.
*/

Console.WriteLine("bir sayı giriniz");
int counter = 1;
int maxNumber = int.MinValue;
int minNumber = int.MaxValue;

while (counter < 10)
{
    Console.WriteLine("lütfen " + counter + ". sayıyı giriniz");
    string input = Console.ReadLine();
    int number;
    bool result = int.TryParse(input, out number);

    if (!result)
    {
        Console.WriteLine("hatalı giriş");
    }
    else
    {
        if (number > maxNumber)
        {
            maxNumber = number;
        }
        if (number < minNumber)
        {
            minNumber = number;
        }
        counter++;
    }
  
}
Console.WriteLine("en büyük sayı = " + maxNumber + "en küçük sayı = " + minNumber);

