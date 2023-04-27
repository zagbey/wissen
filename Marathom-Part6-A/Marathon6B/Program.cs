int max = int.MinValue; // En büyük sayıyı tutacak değişkeni int.MinValue ile başlatır.
int min = int.MaxValue; // En küçük sayıyı tutacak değişkeni int.MaxValue ile başlatır.
bool end = false; // Döngünün ne zaman durdurulacağını belirleyen bool değişkeni end adıyla tanımlar ve false ile başlatır.

while (!end) // Döngü end değişkeni true olana kadar çalışır.
{
    Console.Write("Bir sayı girin veya 'end' yazarak işlemi sonlandırın: "); // Kullanıcıya bir mesaj gösterir.
    string input = Console.ReadLine(); // Kullanıcının girdiği değeri okur ve input adlı bir string değişkene atar.

    if (input.ToLower() == "end") // Eğer kullanıcı "end" yazarsa
    {
        end = true; // end değişkenini true olarak ayarlar ve döngü sonlandırılır.
    }
    else // Aksi takdirde   
    {
        int number; // Kullanıcının girdiği değeri int tipinde tutacak bir değişken tanımlar.
        bool success = int.TryParse(input, out number); // input değişkenini bir tam sayıya dönüştürmeye çalışır. Eğer dönüştürme başarılıysa, dönüştürülen sayı number değişkenine atanır ve success değişkeni true olur. Aksi takdirde, success değişkeni false olur ve number değişkeni varsayılan değeri olan 0 olarak kalır.
         
        if (success) // Eğer girdi bir tam sayıya dönüştürülebiliyorsa
        {
            if (number > max) // Eğer girdi, şimdiye kadar girilen en büyük sayıdan büyükse
            {
                max = number; // max değişkenini girdiye eşitle.
            }

            if (number < min) // Eğer girdi, şimdiye kadar girilen en küçük sayıdan küçükse
            {
                min = number; // min değişkenini girdiye eşitle.
            }
        }
        else // Eğer girdi bir tam sayıya dönüştürülemediyse
        {
            Console.WriteLine("Lütfen bir sayı girin."); // Kullanıcıya bir hata mesajı gösterir.
        }
    }
}

if (max != int.MinValue) // Eğer en büyük sayı int.MinValue'dan farklıysa (yani hiç sayı girilmediyse int.MinValue olacaktır)
{
    Console.WriteLine("En büyük sayı: " + max); // En büyük sayı

}


