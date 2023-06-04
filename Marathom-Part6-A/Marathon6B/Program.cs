/* b. Kullanıcıdan istenecek belirsiz miktardaki sayı içerisinden en büyük ve en küçük olanları tespit edip ekrana sonucu yazan programı geliştirin.
 * Kullanıcıdan toplamda kaç adet sayı alınacağı kullanıcıya bağlı olacak, kullanıcı “end” yazdığında sayı alma işlemi durdurulacak ve sonuçlar ekrana yazdırılacak. 
 * Ancak kullanıcı minimum 2 sayı yazmak zorundadır. Kullanıcının yazdığı değerlerin sayı olup olmadığının kontrolü yapılmalıdır.
 * Kullanıcı uygun formatta sayı yazmazsa (“Yirmibeş”, “üç”, “Muhittin”) uyarı döndürülecek ve girilen değer geçersiz sayılacaktır.
Programı geliştirirken minimum sayıda değişken kullanın, her giriş yapılan değer için değişken oluşturmayın. Ayrıca kodlamada dizi kullanılmayacaktır.
Program hesaplama ve tespit işlemlerini yaptıktan sonra başa dönecek ve tekrar sayı girişi bekleyecektir. Programı sonlandırmak, kullanıcının “exit” yazmasına bağlı olacaktır.
NOT: “end” komutu, eğer ki toplamda 2 sayıya ulaşılmadıysa işlevsiz olacaktır ve uyarı döndürecektir. Ancak “exit” komutu herhangi bir anda doğrudan çalışabilir. 
Ayrıca kullanıcı uygun formatta sayı yazmazsa (“Yirmibeş”, “üç”, “Muhittin”) uyarı döndürülecek ve girilen değer geçersiz sayılacaktır.*/

string input = "";

while (input.ToLower() != "exit")
{
    int Maxnumber = int.MinValue;
    int Minnumber = int.MaxValue;
    int counter = 0;

    while (input.ToLower() != "end" || counter < 2)
    {
        Console.WriteLine("BİR SAYI GİRİNİZ");
        input = Console.ReadLine();

        if (input == "exit")
        {
            break;
        }
        if (input == "end" && counter < 2)
        {
            Console.WriteLine("En az 2 sayı girii yapmalısınız");
        }
        else if (input != "end")
        {
            int number;
            bool result = int.TryParse(input, out number);

            //boolen defoult value is false 
            if (!result)
            {
                Console.WriteLine("hatalı giriş yaptınız");
            }
            else
            {
                if (number > Maxnumber)
                {
                    Maxnumber = number;
                }
                if (number < Minnumber)
                {
                    Minnumber = number;

                    counter++;
                }
            }

        }


    }

    if (input != "exit")
    {
        Console.WriteLine("EN BÜYÜK SAYI : {0},EN KÜÇÜK SAYI {1}:", Maxnumber, Minnumber);
    }

}
