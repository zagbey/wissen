//1 ile 100 arasında 3 e bölünen sayıları bir dizide biriktir 

// sonrasında ekrana yazıran programı geliştirin 

// bitince toplu değişme komtuna bak 
int[] numbers = new int[0];

int counter = 0;
int loop = 1;
while (loop <= 100)
{
    if (loop % 3 == 0)
    {
        Array.Resize(ref numbers, numbers.Length+1); // dizinin boyutunu 1 arttırdık 
        numbers[counter] = loop;                     // numbers dizisindekideki counterıncı elemana loop değişkenini atıyor 
        counter++;
    }
    loop++;
}

Console.WriteLine("1 ile 100 arasında 3'e bölünebilen sayılar:");

int loop2 = 0;

while (loop2 < counter)
{
    Console.WriteLine("[{0}] ----> {1}",loop2,numbers[loop2] );
    loop2++;
}
//numbers lengthi kadar dönen döngü ile consola yazdır 

