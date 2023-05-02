// baştan değerler belliyse 
// initialize : ilk değerini vermek 
string[] players = new string[]
{
    "samsunspor",
    "tuzlaspor",
    "fenerbahçe",
    "bayburtspor",
    "lolipopspor",
    "lolipopnecmispor",
    "siirtköyhizmetleriFC",
};

//1. Tüm elemanları 0'dan başlayarak sona kadar alt alta yazdır 
//2. Tüm elemanları sondan başlayarak başa kadar alt alta yazdır 
//3. Sadece çift indexli elemanları ekrana yazdır 
//4. Sadece tek indexli elemanları ekrana yazdır 
//5. İlk elemanı ortadakini ve sondakini ekrana yazdırın 

int counter = 0;

while (counter < players.Length)
{
    Console.Write(players[counter]);
    counter++;
}

Console.WriteLine("*********************************************");

counter = 7;
while (counter <= 0)
{
    Console.Write(players[counter]);
    counter--;
}

Console.WriteLine("*********************************************");

int counter = 0;

while (counter < players.Length)
{
    if (counter % 2 == 0)
    {
        Console.Write(players[counter]);
    }
    counter++;
}

Console.WriteLine("************************************************");
int counter = 0;

while (counter < players.Length)
{
    if (counter % 2! == 0)
    {
        Console.Write("[{0}]:\t{1}", counter, players[counter]);
    }
    counter++;
}
Console.WriteLine("************************************************");

counter = 0;

while (counter < players.Length)
{
    Console.WriteLine("ilk eleman---> : ", players[0]);           // ilk eleman 
    Console.Write(players[players.Length / 2]);  // ortadaki eleman 
    Console.Write(players[players.Length - 1]); // son eleman 

    counter++;
}


