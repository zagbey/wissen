// 1. IsEven
// Parametreden gelen tamsayının çift sayı olup olmadığını
// hesaplayıp döndüren fonksiyon

bool result = IsEven(10);

Console.WriteLine("10 sayısı çift midir?: {0}", result);


bool IsEven(int number)
{
    return number % 2 == 0;
}

// 2. SquareOf
// Parametreden gelen tamsayının karesini hesap edip
// döndüren fonksiyonu yazın

int SquareOf(int number)
{
    return number * number;
}

// 3. CubeOf
// Parametreden gelen tamsayının küpünü hesap edip
// döndüren fonksiyonu yazın

int CubeOf(int number)
{
    return SquareOf(number) * number;
}

Console.WriteLine("Sonuçlar: {0}", SquareAndCube(10, 5));


// 4. PowerOf
// bir sayının istenen değerdeki kuvvetini hesap eden fonksiyonu yazın

//Console.WriteLine("5'in -3. kuvveti: {0}",(5,3));

//string input = Console.ReadLine();

//if (input.ToLower() == "Öğrenci")
{
    //Console.WriteLine("Öğrencilere bilet satışı mevcut değildir");
}
//else
//{
//    Console.WriteLine("Bilet satın almak için tıklayın");
////}

//double sonuc = PowerOf(5, 2);
Console.WriteLine(PowerOf(5,2));

double PowerOf(int number, int power)
{
    if (power == 0)
        return 1;

    // ternary öperatörü gösterimi
    int absPower = power < 0
        ? -power // power < 0 true ise bu değer absPower değişkenine atanır
        : power; // false ise bu değer absPower değişkenine atanır

    int result = 1;

    for (int counter = 0; counter < absPower; counter++)
    {
        result = result * number;
    }

    // Ternary operatörü ne zaman kullanılabilir?
    // Eğer bir koşula bağlı olarak sol tarafa bir değer gönderiyorsanız
    //   Sol tarafa değer göndermek;
    //   1. değişkene değer atamak olabilir
    //   2. return komutuyla bir fonksiyondan değer döndürmek olabilir
    // uzun uzun if-else blokları yazmak yerine pratik ternary operatörü
    // kullanılabilir

    // string değişken = KOŞUL ? Koşul true ise atanacak değer : false ise atanacak değer

    return power < 0
        ? 1 / (double)result
        : result;


    //if(power < 0)
    //{
    //    return 1 / (double)result;
    //}
    //else
    //{
    //    return result;
    //}
}


// Aşağıdaki örnekler tavsiye edimeyen örneklerdir
int[] results = SquareAndCube(10, 5);

int[] SquareAndCube(int numberForSquare, int numberForCube)
{
    int square = numberForSquare * numberForSquare;
    int cube = numberForCube * numberForCube * numberForCube;

    return new int[] { square, cube };
}


