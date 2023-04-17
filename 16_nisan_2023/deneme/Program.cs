//             *
//           *
//        *
//     *


int satır = 1;


while (satır <= 4)
{
    int sütun = 1;
    while (sütun <= 4)
    {
        if (sütun == 5 - satır)
        {
            Console.Write("*");
        }
        else
        {
            Console.Write(' ');
        }
        sütun++;
    }
    Console.WriteLine();
    satır++;
}





