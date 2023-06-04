// 1-100 arasında 5 e bölünebilen tek sayıları ekrana yan yana sayıların arasına virgül ekleyin

//int number = 0;

//while (number < 100)
//{
//    if (number % 5 == 0 && number %2!=0)
//    {
//        Console.Write(number);

//        if (number != 100 - 5) // Son sayıya ulaştığımızda virgülü yazdırmamak için kontrol ediyoruz
//        {
//            Console.Write(",");
//        }
//    }
//    number++;
//}
//Alternatif çözüm  flag yönetemi 
int number = 1;

// Flag yöntemi
bool flag = false;

while (number <= 100)
{
    // 5
    if (number % 2 != 0 && number % 5 == 0)
    {
        if (flag)
        {
            Console.Write(", ");
        }

        Console.Write(number);

        flag = true;
    }

    number++;
}
