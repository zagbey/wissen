string input = "";

// bu en dıştaki döngü, programın tamamen sonlanması ile ilgili
// eğer kullanıcı "exit" ifadesini giriş yaparsa bu döngü
// sonlanacak
while (input != "exit")
{
    int maxNumber = int.MinValue;
    int minNumber = int.MaxValue;
    int counter = 0;

    // kullanıcıdan belirsiz sayıda input alabilmek için bu döngüyü kullandık
    // döngü koşulu doğrudan bir sayaca bağlı değil
    while (input != "end" || counter < 2)
    {
        Console.WriteLine("Lütfen bir sayı yazınız");
        input = Console.ReadLine();

        // eğer kullanıcı giriş olarak "exit" yazmışsa, kaç adet sayı girişi aldığımıza
        // bakmaksızın döngüyü direkt sonlandırıyoruz
        // çünkü amacımız programın tamamını sonlandırmak
        if (input == "exit")
        {
            // ancak bu break ifadesi sadece bir üstteki döngüyü sonlandırır
            // yani koşulu (input != "end" || counter < 2) olan döngü sonlanacak
            break;
        }

        #region break komutu ile çözüm
        //if (input == "end" && counter >= 2)
        //    break; 
        #endregion

        if (input == "end" && counter < 2)
        {
            Console.WriteLine("En az 2 adet sayı girişi yapmanız gerekmektedir");
        }
        else if (input != "end")
        {
            int number;
            bool parseResult = int.TryParse(input, out number);

            if (!parseResult)
            {
                Console.WriteLine("Hatalı bir giriş yaptınız");
                continue;
            }

            if (number > maxNumber)
                maxNumber = number;

            if (number < minNumber)
                minNumber = number;

            counter++;
        }
    }

    // eğer kullanıcı "exit" yazmamışsa hemen yukarıda bulunan
    // döngü "end" yazıldığı için sonlanmıştır
    // input exit değilse aşağıdaki sonuçları ekrana yazdırabilirim
    if (input != "exit")
    {
        Console.WriteLine("Tespit edilen en büyük sayı: " + maxNumber);
        Console.WriteLine("Tespit edilen en küçük sayı: " + minNumber);
    }
}
// ve en dıştaki döngüden sonra herhangi bir kod satırı
// olmadığı için program otomatik olarak sonlanmış olacak