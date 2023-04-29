/*Kullanıcıdan alınacak iki sayı arasında kalan sayıların kare ve küp değerleri hesaplanacaktır. Kullanıcı iki sayıyı birincisi küçük, ikincisi büyük olacak şekilde veya birincisi büyük, ikincisi küçük olacak şekilde sıraya bağlı kalmaksızın girebilir.
Kullanıcının yazdığı değerlerin sayı olup olmadığının kontrolü yapılmalıdır. Kullanıcı uygun formatta sayı yazmazsa (“Yirmibeş”, “üç”, “Muhittin”) uyarı döndürülecek ve girilen değer geçersiz sayılacaktır.
Yapılan hesaplamalar ekrana üç kolonlu yapıda yazdırılacaktır: Sayı – Karesi – Küpü
Program hesaplama ve tespit işlemlerini yaptıktan sonra başa dönecek ve tekrar sayı girişi bekleyecektir. Programı sonlandırmak, kullanıcının “exit” yazmasına bağlı olacaktır.
*/

string input;
do
{
    int number1, number2;
   
    do
    {
        Console.WriteLine("lütfen 1.sayıyı giriniz");
        input = Console.ReadLine();
     
    } while (!int.TryParse(input, out number1));
    do
    {
        Console.WriteLine("lütfen 2.sayıyı giriniz");
        input = Console.ReadLine();
       
    } while (!int.TryParse(input, out number2));


    if (number1 > number2)
    {
        int temp = number1;
        number1 = number2;
        number2 = temp;
    }
    number1++;
    while (number1 < number2)
    {
        int square = number1 * number1;
        int cube = square * number1;
        Console.WriteLine("Sayı : {0},Karesi: {1}, Küpü: {2}", number1, square, cube);
        number1++;
    }



} while (input.ToLower() != "exit");

/*
 * ﻿string input;

do
{
    int number1, number2;

    do
    {
        Console.WriteLine("Lütfen 1. sayıyı yazınız");
        input = Console.ReadLine();
    } while (!int.TryParse(input, out number1));

    do
    {
        Console.WriteLine("Lütfen 2. sayıyı yazınız");
        input = Console.ReadLine();
    } while (!int.TryParse(input, out number2));

    // number1 -> 10 --> 5
    // number2 -> 5  --> 10

    if (number1 > number2)
    {
        // iki değişkenin değerini yer değiştir
        int temp = number1;
        number1 = number2;
        number2 = temp;
    }

    number1++;
    while(number1 < number2)
    {
        int square = number1 * number1;
        int cube = square * number1;

        // string format
        Console.WriteLine("Sayı: {0}, Karesi: {1}, Küpü: {2}", number1, square, cube);
        //Console.WriteLine("Sayı: " + number1 + ", Karesi: " + square + ", Küpü: " + cube);
        number1++;
    }


} while (input.ToLower() != "exit");
*/