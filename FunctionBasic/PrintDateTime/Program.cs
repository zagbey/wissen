//PrinDateTime()
//Ekrana programın çalışma anındaki tarih ve saat bilgisini ekrana yazdıran fonksiyonu geliştirin

// örnek çıktı Tarih: 09-05-2023, saat: 20:58;


string day = DateTime.Now.Day.ToString().PadLeft(2, '0');
string month = DateTime.Now.Month.ToString();
string year = DateTime.Now.Year.ToString();
string time = DateTime.Now.TimeOfDay.ToString();

Console.WriteLine("{0}-{1}-{2} saat {3}", day, month, year, time);

//bir tamsayı dizisini ekrana yazdıran fonksiyonu geliştirin 
Console.Write("****************************************************\n");
int[] number =
{
    1,2,5,6,7,8,9
};

NumberLine(number);


void NumberLine(int[] number)

{
    for (int i = 0; i < number.Length; i++)
    {
        Console.WriteLine(number[i]);
    }
}

Console.Write("****************************************************\n");

//PrintArrayExtra(int[],bool)
//Bir tamsayı dizini, istenen yönde yazdırılacak olan fonksiyonu geliştirin 
//int[] tipindeki birinci parametre yazdırılacak olan dizi bool tipindeki 
//bool tipindeki ikinci parametre ise dizinin yatay(yan yana) şeklinde veya 
//dikey(alt alta) şeklinde yazılacağını bildirecek. true - yatay , false-dikey 


